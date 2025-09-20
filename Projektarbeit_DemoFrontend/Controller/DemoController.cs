using Projektarbeit_DemoFrontend.Entities;
using Projektarbeit_DemoFrontend.Service;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Projektarbeit_DemoFrontend.Controller
{
    public class DemoController
    {
        UserInterfaceView uiView = new UserInterfaceView();

        ArticleService ArticleService = new ArticleService();
        CustomerService CustomerService = new CustomerService();
        VendorService VendorService = new VendorService();

        public DemoController()
        {
            while (true)
            {
                int selection = uiView.GetSelection([
                    "Alle Artikel anzeigen",
                    "Alle Kunden anzeigen",
                    "Alle Lieferanten anzeigen",



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
    }
}
