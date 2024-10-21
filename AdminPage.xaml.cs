using System;

namespace PharmacyWaitingRoom
{
    public partial class AdminPage : ContentPage
    {
        private static int currentTicket = 1; // Track current serving ticket

        public AdminPage()
        {
            InitializeComponent();
        }

        private void OnNextTicketClicked(object sender, EventArgs e)
        {
            // Serve the next ticket
            string nextTicket = $"T{currentTicket:D3}";
            ServingTicketLabel.Text = nextTicket;

            // Increment to the next ticket to be served
            currentTicket++;

            // Optionally: Update the ticket status in a database or service (omitted for simplicity)

        }

        private async void OnAdminClicked(object sender, EventArgs e)
        {
            // Navigate to the Admin Page
            await Navigation.PushAsync(new MainPage());
        }
    }
}
