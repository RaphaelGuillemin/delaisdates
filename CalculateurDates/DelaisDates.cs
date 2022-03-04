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
            DateTime newTime = newDate.AddDays(checkWeekendAndHoliday(newDate, datePickerDeclarationAppel.Value.Month, this.delaisMaxDepotMemoireAppelant));
            dateLimiteDepotMemoireAppelant.Text = newTime.ToShortDateString();
            datePickerMemoireAppelant.Value = newTime;
        }

        private void datePickerMemoireAppelant_ValueChanged(object sender, EventArgs e)
        {
            int initialMonth = datePickerMemoireAppelant.Value.Month;
            DateTime newDateIntime = datePickerMemoireAppelant.Value.AddMonths(delaisMaxDepotMemoireIntime);
            DateTime newDateMEC = datePickerMemoireAppelant.Value.AddMonths(delaisMaxDepotMemoireIntervenant);
            dateLimiteDepotMemoireIntime.Text = newDateIntime.AddDays(checkWeekendAndHoliday(newDateIntime, initialMonth, this.delaisMaxDepotMemoireIntime)).ToShortDateString();
            dateLimiteDepotMemoireMisEnCause.Text = newDateMEC.AddDays(checkWeekendAndHoliday(newDateMEC, initialMonth, this.delaisMaxDepotMemoireIntervenant)).ToShortDateString();
        }

        private int checkWeekendAndHoliday(DateTime date, int initialMonth, int monthLimit)
        {
            int days = 0;
            DateTime newDate = date;
            DateTime tempDate = newDate;
            while ((feries.Contains(tempDate) || tempDate.DayOfWeek == DayOfWeek.Saturday || tempDate.DayOfWeek == DayOfWeek.Sunday) && days < 30)
            {
                if (tempDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    days += 2;
                }
                else
                {
                    days += 1;
                }
                tempDate = new DateTime(date.Year, date.Month, date.Day, 00, 00, 00).AddDays(days);
            }
            if (tempDate.Month - initialMonth > monthLimit)
            {
                days = 0;
                tempDate = newDate;
                while ((feries.Contains(tempDate) || tempDate.DayOfWeek == DayOfWeek.Saturday || tempDate.DayOfWeek == DayOfWeek.Sunday) && days < 30)
                {
                    if (tempDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        days -= 2;
                    }
                    else
                    {
                        days -= 1;
                    }
                    tempDate = new DateTime(date.Year, date.Month, date.Day, 00, 00, 00).AddDays(days);
                }
            }
                
            return days;
        }
    }
}
