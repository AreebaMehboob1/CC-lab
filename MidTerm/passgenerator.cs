using System;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This method will run when you click the "Generate Password" button
        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            // Get user input from text boxes
            string registrationNumber = txtRegistrationNumber.Text; // Should be 2 digits
            string firstName = txtFirstName.Text.ToLower();         // Get first name input
            string lastName = txtLastName.Text.ToLower();           // Get last name input
            string favoriteMovie = txtFavoriteMovie.Text.ToLower(); // Get favorite movie input

            // Check if input is valid
            if (firstName.Length < 2 || lastName.Length < 2 || registrationNumber.Length != 2)
            {
                MessageBox.Show("Please enter valid input (at least 2 characters for names and 2 digits for registration number).");
                return;
            }

            // Extract second letters
            char secondLetterFirstName = firstName[1]; // e.g., 'r' from "areeba"
            char secondLetterLastName = lastName[1];   // e.g., 'e' from "mehboob"

            // Predefined movie characters (from the first letters of the movie "punjab nahi jau gi")
            string movieChars = "pj"; 

            // Define a special character
            string specialChar = "%"; // chosen special character

            // Combine all the parts to form the password
            string password = secondLetterLastName + 
                              registrationNumber + 
                              secondLetterFirstName + 
                              secondLetterLastName + 
                              specialChar + 
                              "@" + 
                              "K" + 
                              movieChars + 
                              "w6";

            // Display the generated password in the label
            lblGeneratedPassword.Text = "Generated Password: " + password;
        }
    }
}
