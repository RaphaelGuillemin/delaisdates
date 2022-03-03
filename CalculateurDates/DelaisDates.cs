using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculateurDates
{
    public partial class DelaisDates : Form
    {
        public int delaisMaxDepotMemoireAppelant = 3;
        public int delaisMaxDepotMemoireIntime = 2;
        public int delaisMaxDepotMemoireIntervenant = 4;

        public List<DateTime> feries = new List<DateTime>(); 
        public DelaisDates()
        {
            InitializeComponent();
            feries.Add(new DateTime(2022, 01, 01, 00, 00, 00));
            feries.Add(new DateTime(2022, 04, 15, 00, 00, 00));
            feries.Add(new DateTime(2022, 04, 18, 00, 00, 00));
            feries.Add(new DateTime(2022, 05, 23, 00, 00, 00));
            feries.Add(new DateTime(2022, 06, 24, 00, 00, 00));
            feries.Add(new DateTime(2022, 07, 01, 00, 00, 00));
            feries.Add(new DateTime(2022, 08, 01, 00, 00, 00));
            feries.Add(new DateTime(2022, 09, 05, 00, 00, 00));
            feries.Add(new DateTime(2022, 09, 30, 00, 00, 00));
            feries.Add(new DateTime(2022, 10, 10, 00, 00, 00));
            feries.Add(new DateTime(2022, 11, 11, 00, 00, 00));
            feries.Add(new DateTime(2022, 12, 25, 00, 00, 00));
            feries.Add(new DateTime(2022, 12, 26, 00, 00, 00));
        }

        private void reinitialiserLesDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datePickerDeclarationAppel.Value = DateTime.Today;
            datePickerMemoireAppelant.Value = DateTime.Today.AddMonths(delaisMaxDepotMemoireAppelant);
            dateLimiteDepotMemoireAppelant.Text = "";
            dateLimiteDepotMemoireIntime.Text = "";
            dateLimiteDepotMemoireMisEnCause.Text = "";
        }

        private void datePickerDeclarationAppel_ValueChanged(object sender, EventArgs e)
        {
            DateTime newDate = datePickerDeclarationAppel.Value.AddMonths(delaisMaxDepotMemoireAppelant);
            DateTime newTime = newDate.AddDays(checkWeekendAndHoliday(newDate));
            dateLimiteDepotMemoireAppelant.Text = newTime.ToShortDateString();
            datePickerMemoireAppelant.Value = newTime;
        }

        private void datePickerMemoireAppelant_ValueChanged(object sender, EventArgs e)
        {
            DateTime newDateIntime = datePickerMemoireAppelant.Value.AddMonths(delaisMaxDepotMemoireIntime);
            DateTime newDateMEC = datePickerMemoireAppelant.Value.AddMonths(delaisMaxDepotMemoireIntervenant);
            dateLimiteDepotMemoireIntime.Text = newDateIntime.AddDays(checkWeekendAndHoliday(newDateIntime)).ToShortDateString();
            dateLimiteDepotMemoireMisEnCause.Text = newDateMEC.AddDays(checkWeekendAndHoliday(newDateMEC)).ToShortDateString();
        }

        private int checkWeekendAndHoliday(DateTime date)
        {
            int days = 0;
            DateTime newDate = date;
            while ((feries.Contains(newDate) || newDate.DayOfWeek == DayOfWeek.Saturday || newDate.DayOfWeek == DayOfWeek.Sunday) && days < 30)
            {
                if (newDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    days += 2;
                }
                else
                {
                    days += 1;
                }
                newDate = new DateTime(date.Year, date.Month, date.Day, 00, 00, 00).AddDays(days);
            }
            return days;
        }
    }
}
