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
        public List<DateTime> selectionFeriesToDelete = new List<DateTime>();

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
            DateTime date = new DateTime(datePickerDeclarationAppel.Value.Year, datePickerDeclarationAppel.Value.Month, datePickerDeclarationAppel.Value.Day, 0, 0, 0);
            datePickerDeclarationAppel.Value = date;
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
            while ((feriesContains(tempDate) || tempDate.DayOfWeek == DayOfWeek.Saturday || tempDate.DayOfWeek == DayOfWeek.Sunday) && days < 30)
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
                while ((feriesContains(tempDate) || tempDate.DayOfWeek == DayOfWeek.Saturday || tempDate.DayOfWeek == DayOfWeek.Sunday) && days < 30)
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

        public bool feriesContains(DateTime item)
        {
            DateTime date = new DateTime(item.Year, item.Month, item.Day, 0, 0, 0);
            return feries.Contains(date);
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "mainTab")
            {
                clearFlowLayoutPanelFerieTab();
            }
            else if (tabControl.SelectedTab.Name == "joursFeries")
            {
                joursFeriesTab_Click();
            }    
        }
        private void joursFeriesTab_Click()
        {
            refreshJoursFeries();
        }

        private void clearFlowLayoutPanelFerieTab()
        {
            tableLayoutPanelFeries.Controls.Clear();
            flowLayoutPanelnewFeries.Controls.Clear();
        }

        private void refreshJoursFeries()
        {
            tableLayoutPanelFeries.Controls.Clear();
            feries.Sort((x, y) => DateTime.Compare(x,y));
            int row = 0;
            for (int i = 0; i < feries.Count; i++)
            {
                int column = 0;
                DateTime date = feries[i];
                DateTimePicker datePicker = new DateTimePicker();
                datePicker.Name = "" + i;
                datePicker.Dock = DockStyle.Fill;
                datePicker.Value = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
                datePicker.Enabled = false;
                tableLayoutPanelFeries.Controls.Add(datePicker, column, row);
                
                ++column;
                CheckBox checkBox = new CheckBox();
                checkBox.Anchor = AnchorStyles.None;
                checkBox.AutoSize = true;
                checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                checkBox.Size = new System.Drawing.Size(18, 18);
                checkBox.Name = "" + row + "_" + column;
                checkBox.Checked = false;
                checkBox.CheckedChanged += new EventHandler(checkboxFerie_Click);
                tableLayoutPanelFeries.Controls.Add(checkBox, column, row);
                ++row;
            }
        }

        private void checkboxFerie_Click(object sender, EventArgs e)
        {
            CheckBox checkboxClicked = (CheckBox)sender;
            try
            {
                String[] position = checkboxClicked.Name.Split('_');
                int row = Int32.Parse(position[0]);
                int column = Int32.Parse(position[1]);
                Control control = tableLayoutPanelFeries.GetControlFromPosition(column-1, row);
                DateTimePicker datePicker = (DateTimePicker)control;
                DateTime date = datePicker.Value;
                if (date == null)
                {
                    return;
                }
                if (checkboxClicked.Checked)
                {
                    if (selectionFeriesToDelete.Contains(date))
                    {
                        return;
                    }    
                    selectionFeriesToDelete.Add(date);
                }
                else
                {
                    if (selectionFeriesToDelete.Contains(date))
                    {
                        selectionFeriesToDelete.Remove(date);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{checkboxClicked.Name}'");
            }
        }

        private void buttonAddFerie_Click(object sender, EventArgs e)
        {
            DateTimePicker datePicker = new DateTimePicker();
            datePicker.Value = DateTime.Today;
            flowLayoutPanelnewFeries.Controls.Add(datePicker);
        }

        private void buttonDeleteFerie_Click(object sender, EventArgs e)
        {
            if (selectionFeriesToDelete.Count < 1)
            {
                return;
            }
            foreach (DateTime date in selectionFeriesToDelete)
            {
                if (!feriesContains(date))
                {
                    continue;
                }
                feries.Remove(date);
            }
            selectionFeriesToDelete.Clear();
            refreshJoursFeries();

        }

        private void buttonCancelFeries_Click(object sender, EventArgs e)
        {
            clearFlowLayoutPanelFerieTab();
            tabControl.SelectedTab = tabControl.TabPages["mainTab"];
        }

        private void buttonOkFeries_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelnewFeries.Controls.Count < 1)
            {
                return;
            }
            foreach (DateTimePicker datePicker in flowLayoutPanelnewFeries.Controls)
            {
                DateTime date = datePicker.Value;
                if (feries.Contains(date))
                {
                    continue;
                }
                feries.Add(date);
            }
            flowLayoutPanelnewFeries.Controls.Clear();
            refreshJoursFeries();
        }
    }

}
