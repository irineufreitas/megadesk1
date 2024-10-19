using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bohman
{
    public class DeskQuote
    {
        private string customerName;
        private Desk deskDetails;
        private OrderTimeFrame orderTimeFrame;
        private int quotePrice;
        private DateTime quoteDate;
        static public string PREPENDED_PRICE_UNIT = "$";
        // Dictionary/table of fee values according to the combination of production time and desk size.
        /*static public int[,] rushOrderFees = {
            {60, 70, 80},
            {40, 50, 60},
            {30, 35, 40},
            {0, 0, 0}
        };*/
        private RushOrderManager rushOrderManager = new RushOrderManager();
        // Table of price of surface materials for a desk, depending on the DesktopMaterial enum value.
        static public int[] materialPrices = {
            200,
            100,
            50,
            300,
            125
        };
        static public string[] orderTimeFrameTextValues =
        {
            "3 days",
            "5 days",
            "7 days",
            "14 days"
        };

        public DeskQuote(string customerName, int width, int depth, int numDrawers, DesktopMaterial material, OrderTimeFrame orderTimeFrame)
        {
            this.customerName = customerName;
            this.deskDetails = new Desk(width, depth, numDrawers, material);
            this.orderTimeFrame = orderTimeFrame;
            this.quotePrice = CalculatePrice();
            this.quoteDate = DateTime.Now;
            this.rushOrderManager = new RushOrderManager();
        }

        public DeskQuote(DeskQuoteDTO dto)
        {
            this.customerName = dto.customerName;
            this.deskDetails = dto.deskDetails;
            this.orderTimeFrame = dto.orderTimeFrame;
            this.quotePrice = dto.quotePrice;
            this.quoteDate = dto.quoteDate;
        }

        static public int GetMaterialCost(DesktopMaterial deskMaterial) {
            return materialPrices[(int)deskMaterial];
        }

        private Size GetSizeOfDeskTier(int surfaceArea)
        {
            Size sizeOfDeskTier;
            switch (surfaceArea)
            {
                case int x when x < 1000:
                    sizeOfDeskTier = Size.small;
                    break;
                case int x when x >= 1000 && x <= 2000:
                    sizeOfDeskTier = Size.medium;
                    break;
                default: // when surfaceArea > 2000
                    sizeOfDeskTier = Size.large;
                    break;
            }
            return sizeOfDeskTier;
        }

        private string GetOrderTimeFrame()
        {
            return DeskQuote.orderTimeFrameTextValues[(int)this.orderTimeFrame];
        }

        int calculateSurfaceAreaCost(int surfaceArea)
        {
            // Cost is $1 for each square inch that exceeds 1000 square inches.
            if (surfaceArea > 1000)
            {
                return surfaceArea - 1000;
            }
            else
            {
                return 0;
            }
        }

        public int CalculatePrice()
        {
            int materialCost = GetMaterialCost(deskDetails.material);
            int surfaceArea = deskDetails.width * deskDetails.depth;
            int surfaceAreaCost = calculateSurfaceAreaCost(surfaceArea);
            int rushOrderFee = GetRushOrderFee(surfaceArea, orderTimeFrame);
            quotePrice = 200 + surfaceAreaCost + (50 * deskDetails.numDrawers) + materialCost+ rushOrderFee;
            return quotePrice;
        }

        public void GetQuoteDetails(out string customerName, out Desk deskDetails, out string orderTimeFrame, out int quotePrice, out DateTime quoteDate)
        {
            customerName = this.customerName;
            deskDetails = this.deskDetails;
            orderTimeFrame = GetOrderTimeFrame();
            quotePrice = this.quotePrice;
            quoteDate = this.quoteDate;
        }

        public int GetRushOrderFee(int surfaceArea, OrderTimeFrame orderTimeFrame)
        {
            int rushDays;

            switch (orderTimeFrame)
            {
                case OrderTimeFrame._3days:
                    rushDays = 3;
                    break;
                case OrderTimeFrame._5days:
                    rushDays = 5;
                    break;
                case OrderTimeFrame._7days:
                    rushDays = 7;
                    break;
                default:
                    return 0; // No rush order fee for 14 days
            }

            // Calculate desk size
            int deskSize = surfaceArea;

            // Use RushOrderManager to get the correct rush order price
            return rushOrderManager.GetRushOrderPrice(rushDays, deskSize);
        }
            private static string GetPathToJsonFile()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            int binIndex = projectDirectory.IndexOf("bin");
            int debugIndex = projectDirectory.IndexOf("Debug");
            string dataDirectoryName = "data";

            if (binIndex >= 0 || debugIndex >= 0)
            {
                int endIndex = Math.Min(binIndex >= 0 ? binIndex : int.MaxValue, debugIndex >= 0 ? debugIndex : int.MaxValue);
                projectDirectory = projectDirectory.Substring(0, endIndex);
            }

            return Path.Combine(projectDirectory + $"\\{dataDirectoryName}\\", "quotes.json");
        }

        static public List<DeskQuoteDTO> ReadAllQuotesFromJsonFileIntoDTOList()
        {
            string jsonFilePath = GetPathToJsonFile();
            if (!File.Exists(jsonFilePath))
            {
                return new List<DeskQuoteDTO>(); // Return an empty list if the file doesn't exist
            }
            string existingJson = File.ReadAllText(jsonFilePath);
            List<DeskQuoteDTO> existingQuotes = JsonConvert.DeserializeObject<List<DeskQuoteDTO>>(existingJson) ?? new List<DeskQuoteDTO>();
            return existingQuotes;
        }

        public void SaveQuoteToJsonFile()
        {
            string jsonFilePath = GetPathToJsonFile();
            List<DeskQuoteDTO> existingQuotes = ReadAllQuotesFromJsonFileIntoDTOList();

            var submittedQuoteDTO = new DeskQuoteDTO
            {
                customerName = this.customerName,
                deskDetails = this.deskDetails,
                orderTimeFrame = this.orderTimeFrame,
                quotePrice = this.quotePrice,
                quoteDate = this.quoteDate
            };

            existingQuotes.Add(submittedQuoteDTO);
            string updatedJson = JsonConvert.SerializeObject(existingQuotes, Formatting.Indented);
            File.WriteAllText(jsonFilePath, updatedJson);
        }
        public static List<DeskQuote> LoadAllQuotes()
        {
            List<DeskQuoteDTO> existingQuotesDTO = ReadAllQuotesFromJsonFileIntoDTOList();

            // Convert DTOs to DeskQuote instances
            List<DeskQuote> existingQuotes = existingQuotesDTO.Select(dto => new DeskQuote(dto)).ToList();

            return existingQuotes;
        }

        // Filter all saved quotes by the selected desktop material.
        static public List<DeskQuote> FilterAllQuotesByMaterial(DesktopMaterial selectedMaterial)
        {
            List<DeskQuote> existingQuotes = LoadAllQuotes();;
            List<DeskQuote> quoteSearchResults = new List<DeskQuote>();

            for (int i = 0; i < existingQuotes.Count; i++)
            {
                if (existingQuotes[i].deskDetails.material == selectedMaterial)
                {
                    quoteSearchResults.Add(existingQuotes[i]);
                }
            }
            return quoteSearchResults;
        }


    }

    public enum OrderTimeFrame
    {
        _3days,
        _5days,
        _7days,
        _14days
    };
}
