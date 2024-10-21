using System;

namespace PharmacyWaitingRoom
{
    public partial class MainPage : ContentPage
    {
        private static int ticketCounter = 1; // Global ticket counter
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGenerateTicketClicked(object sender, EventArgs e)
        {
            // Generate a new ticket number
            string newTicket = $"T{ticketCounter:D3}"; // T001, T002, etc.
            TicketNumberLabel.Text = newTicket;

            // Increment the ticket counter for the next user
            ticketCounter++;

            // Optionally: Send ticket info to a database or service (omitted for simplicity)
        }

        private async void OnAdminClicked(object sender, EventArgs e)
        {
            // Navigate to the Admin Page
            await Navigation.PushAsync(new AdminPage());
        }

    }
}
