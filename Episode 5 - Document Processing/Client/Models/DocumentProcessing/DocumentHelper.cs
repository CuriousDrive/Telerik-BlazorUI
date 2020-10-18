using BookStores.Models;
using System;
using System.Net;
using Telerik.Windows.Documents.Fixed.Model.Editing.Lists;

namespace BookStores.Client.Models.DocumentProcessing
{
    public class DocumentHelper
    {
        private static readonly Random random;
        private static readonly int StartingId = 1000;
        private static readonly string[] ClientNames = { "Agnes Hill", "Alexandra Kennedy", "Alison Ross", "Alison Thompson", "Charles Miller", "Edward Hall",
                                                   "Francis Stevens", "Glenda White", "Gregory Morrison", "Hannah Watson", "Jack Sims", "James Smith", "Jennie Walker",
                                                   "Jerry Wright", "Joe Lawrence", "Juan Jacobs", "Kara Wood", "Keith Clark", "Lynda Evans", "Marian Rodriguez",
                                                   "Mark Moore", "Natasha Green", "Nora Allen", "Patty Prince", "Ralph Burke", "Robyn Mason", "Roger Peters",
                                                   "Samuel Green", "Scott Fox", "Scott Lewis", "Terry Lawson"};

        private static readonly string[] Companies = { "Circuit Design", "Excella", "Integra Design", "Plan Smart", "Webcom Services", "Zig Zag Coder" };
        private static readonly int MaximumMinutesBetweenOrders = 40;

        private static Client[] Clients;

        static DocumentHelper()
        {
            random = new Random();
        }

        public static DocumentRow GenerateDocumentRow(int documentRowsCount, int rowIndex)
        {
            if (Clients == null)
            {
                InitializeClients();
            }

            int id = StartingId + rowIndex;

            int minuteDelta = random.Next(MaximumMinutesBetweenOrders);
            DateTime beginingDate = DateTime.Now.Date.AddMinutes((documentRowsCount - rowIndex) * MaximumMinutesBetweenOrders * -1);
            DateTime date = beginingDate.AddMinutes(minuteDelta * -1);
            DateTime time = date;

            int clinetIndex = random.Next(Clients.Length);
            Client client = Clients[clinetIndex];

            double discount = random.Next(15) / 100f;

            Shipping shipping = (Shipping)random.Next(Enum.GetValues(typeof(Shipping)).Length);

            DocumentRow row = new DocumentRow(
                id,
                date,
                time,
                client,
                discount,
                shipping);

            return row;
        }

        private static void InitializeClients()
        {
            Clients = new Client[ClientNames.Length];
            for (int i = 0; i < Clients.Length; i++)
            {
                int companyIndex = random.Next(0, Companies.Length);
                Clients[i] = new Client(ClientNames[i], Companies[companyIndex]);
            }
        }
    }
}
