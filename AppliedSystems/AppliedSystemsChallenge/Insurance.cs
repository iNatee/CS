using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliedSystemsChallenge
{
    public partial class Insurance : Form
    {
        public Insurance()
        {
            InitializeComponent();
        }

        double premium = 500; //The premium amount
        int dvrAge; //Age of the driver
        String dvrOcc, dvrName; //The driver's occupation and name
        String declineAge, declineStartDate; //Aspects of the decline message
        DateTime PolicyStartDate; //The Date the policy begins
        Boolean infoValid = true; //Whether or not the user has entered all information nessesary and it meets the standard


        /*
         * A Method to calculate the insurance premium based on 
         * the information provided by the user. Applied in the
         * event handler for clicking the submit button.
         */
        private double CalculatePremium()
        {
            premium = 500;
            double premiumModifier = 0;

            if (dvrOcc == "Chauffeur")
            {
                premiumModifier -= 0.10; //Takes 10% from the premium modifier (Adds 10% to price)
            }

            else if (dvrOcc == "Accountant")
            {
                premiumModifier += 0.10; //Adds 10% to the premium modifier (Takes 10% from price)
            }

            if (dvrAge >= 17 && dvrAge <= 25)
            {
                premiumModifier -= 0.20; //Takes 20% from the premium modifier (Adds 20% to price)
            }

            else if (dvrAge > 25 && dvrAge < 76)
            {
                premiumModifier += 0.10; //Adds 10% to the premium modifier (Takes 10% from price)
            }

            premium -= (premiumModifier * premium); //Calculates the new premium using the modifier

            return premium; //Returns the premium

        }//END CalculatePremium


        /*
         * A Method to determine whether the information provided is 
         * acceptable to the insurance company
         */
        private Boolean Valid()
        {
            if (dvrName == null || dvrOcc == null || PolicyStartDate.Date < DateTime.Today.Date || dvrAge < 17 || dvrAge > 75)
            {
                infoValid = false; //Unacceptable information
            }

            else
            {
                infoValid = true; //Acceptable information
            }

            return infoValid; //Returns whether the information was valid or not

        }//END Valid

       


        private void DtpDriverDoB_ValueChanged(object sender, EventArgs e)
        {
            dvrAge = DateTime.Today.Year - dtpDriverDoB.Value.Year; //Determines the user's age using their given DOB and the current date
        }//END DtpDriverDoB_ValueChanged

        private void CbxDriverOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvrOcc = cbxDriverOccupation.SelectedItem.ToString(); //Records the user's occupation using the information they gave
        }//END CbxDriverOccupation_SelectedIndexChanged

        private void DtpPolicyStartDate_ValueChanged(object sender, EventArgs e)
        {
            PolicyStartDate = dtpPolicyStartDate.Value.Date; //Records the date the user's policy begins according to their information
        }//END DtpPolicyStartDate_ValueChanged

        private void BtnSubmit_Click(object sender, EventArgs e)
        {  
            if (dvrAge < 16)
            {
                declineAge = "Driver is too young"; //Error message for Driver Age
            }

            else if (dvrAge > 75)
            {
                declineAge = "Driver is too old"; //Error message for Driver Age
            }

            else
            {
                declineAge = ""; //No error
            }

            if (PolicyStartDate.Date < DateTime.Today.Date)
            {
                declineStartDate = "Start Date of Policy cannot be in the past"; //Error message for policy start date
            }

            else
            {
                declineStartDate = ""; //No error
            }

            if (Valid() == true)
            {
                premium = CalculatePremium(); //Applies Calculate Premium
                lblPremium.Text = dvrName + " the " + dvrOcc + "'s policy premium is "+ "£" + premium.ToString(); //Prints the premium in the lblPremium label
                lblDecline.Text = "";//No decline message
            }

            else
            { 
                lblPremium.Text = ""; //No premium printed as user info is invalid
                lblDecline.Text = declineStartDate + "\n" + declineAge; //Decline message
            }

        }//END BtnSubmit_Click

        private void TxtDriverName_TextChanged(object sender, EventArgs e)
        {
            dvrName = txtDriverName.Text;

        }//END TxtDriverName_TextChanged

    }//END class
}//END namespace
