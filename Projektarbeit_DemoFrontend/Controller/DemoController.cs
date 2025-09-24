using Projektarbeit_DemoFrontend.Entity;
using Projektarbeit_DemoFrontend.ReportBuilder;
using Projektarbeit_DemoFrontend.Service;

namespace Projektarbeit_DemoFrontend.Controller
{
    public class DemoController
    {
        UserInterfaceView uiView = new UserInterfaceView();

        ArticleService ArticleService = new ArticleService();
        CustomerService CustomerService = new CustomerService();
        VendorService VendorService = new VendorService();
        ReportTypeService ReportTypeService = new ReportTypeService();
        ReportService ReportService = new ReportService();

        public DemoController()
        {
            while (true)
            {
                int selection = uiView.GetSelection([
                    "Alle Artikel anzeigen",
                    "Alle Kunden anzeigen",
                    "Alle Lieferanten anzeigen",
                    "Auswertung erstellen",


                    "Programm beenden"
                ]);

                switch (selection) {
                    case 0:
                        DisplayAllArticles();
                        break;


                    case 1:
                        DisplayAllCustomers();
                        break;

                    case 2:
                        DisplayAllVendors();
                        break;


                    case 3:
                        GenerateReport();
                        break;

                    default:
                        return;

                }

                uiView.ClearConsoleOnButtonPress();
            }
        }

        private void DisplayAllArticles()
        {
            try
            {
                var articles = ArticleService.All();

                var printList = new List<string[]>();

                string[] headings = ["ID", "Name", "Beschreibung", "Preis"];

                foreach (var article in articles)
                {
                    printList.Add([
                        article.Id.ToString(),
                        article.Name,
                        article.Description,
                        article.Price.ToString()
                    ]);

                }

                uiView.PrintTable("Liste aller Artikel:", headings, printList);
            }
            catch (Exception e)
            {
                uiView.Print("An error occured: " + e.Message);
            }
        }

        private void DisplayAllCustomers()
        {
            try
            {
                var customers = CustomerService.All();

                var printList = new List<string[]>();

                string[] headings = ["ID", "Name", "Email", "Telefon", "Strasse", "Ort", "Plz", "Land", "Erstellungsdatum"];

                foreach (var customer in customers)
                {
                    printList.Add(new string[]
                    {
                        customer.Id.ToString(),
                        customer.Name,
                        customer.Email,
                        customer.Phone,
                        customer.Address,
                        customer.City,
                        customer.Zip,
                        customer.Country,
                        customer.CreationDate.ToString("yyyy-MM-dd")
                    });
                }

                uiView.PrintTable("Liste aller Kunden:", headings, printList);
            }
            catch (Exception e)
            {
                uiView.Print("An error occured: " + e.Message);
            }
        }

        private void DisplayAllVendors()
        {
            try
            {
                var vendors = VendorService.All();

                var printList = new List<string[]>();

                string[] headings = ["ID", "Name", "Email", "Telefon", "Strasse", "Ort", "Plz", "Land", "Erstellungsdatum"];

                foreach (var vendor in vendors)
                {
                    printList.Add(new string[]
                    {
                        vendor.Id.ToString(),
                        vendor.Name,
                        vendor.Email,
                        vendor.Phone,
                        vendor.Address,
                        vendor.City,
                        vendor.Zip,
                        vendor.Country,
                        vendor.CreationDate.ToString("yyyy-MM-dd")
                    });
                }

                uiView.PrintTable("Liste aller Lieferanten:", headings, printList);
            }
            catch (Exception e)
            {
                uiView.Print("An error occured: " + e.Message);
            }
        }

        private void GenerateReport()
        {
            var reportTypes = ReportTypeService.All();

            var reportNames = reportTypes
                .Select(q => q.Name)
                .ToList();

            int selectedIndex = uiView.GetSelection(reportNames, "Bitte wählen Sie den zu erstellenden Bericht:");

            var selectedType = reportNames[selectedIndex];
            Report newReport;
            string[] headings;

            switch (selectedType)
            {
                case ArticlesInStockReportBuilder.ReportName:
                    ArticlesInStockReportBuilder.GenerateReport(selectedIndex+1);
                    break;

                case PendingCustomerReportBuilder.ReportName:
                    PendingCustomerReportBuilder.GenerateReport(selectedIndex + 1);
                    break;

                case VendorReportBuilder.ReportName:
                    VendorReportBuilder.GenerateReport(selectedIndex + 1);
                    break;

                default:
                    uiView.Print("Ein Fehler ist aufgetreten. Bitte versuchen Sie es später erneut.");
                    return;
            }

            uiView.Print(selectedType + " erstellt.");
        }
    }
}
