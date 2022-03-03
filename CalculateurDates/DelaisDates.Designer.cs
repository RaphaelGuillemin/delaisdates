using System;
using System.Drawing;

namespace CalculateurDates
{
    partial class DelaisDates
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelaisDates));
            this.datePickerDeclarationAppel = new System.Windows.Forms.DateTimePicker();
            this.datePickerMemoireAppelant = new System.Windows.Forms.DateTimePicker();
            this.labelDepotDeclarationAppel = new System.Windows.Forms.Label();
            this.labelDateLimiteDepotMemoireAppelant = new System.Windows.Forms.Label();
            //this.labelDateLimiteDepotMemoireAppelant2 = new System.Windows.Forms.Label();
            this.labelDateLimiteDepotMemoireIntime = new System.Windows.Forms.Label();
            //this.labelDateLimiteDepotMemoireIntime2 = new System.Windows.Forms.Label();
            this.labelDateDepotMemoireMisEnCause = new System.Windows.Forms.Label();
            this.labelDepotMemoireAppelant = new System.Windows.Forms.Label();
            //this.labelDepotMemoireAppelant2 = new System.Windows.Forms.Label();
            this.dateLimiteDepotMemoireAppelant = new System.Windows.Forms.TextBox();
            this.dateLimiteDepotMemoireIntime = new System.Windows.Forms.TextBox();
            this.dateLimiteDepotMemoireMisEnCause = new System.Windows.Forms.TextBox();
            this.MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.reinitialiseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePickerDeclarationAppel
            // 
            this.datePickerDeclarationAppel.Location = new System.Drawing.Point(12, 51);
            this.datePickerDeclarationAppel.Name = "datePickerDeclarationAppel";
            this.datePickerDeclarationAppel.Size = new System.Drawing.Size(200, 26);
            this.datePickerDeclarationAppel.TabIndex = 0;
            this.datePickerDeclarationAppel.Value = new System.DateTime(2022, 3, 2, 0, 0, 0, 0);
            this.datePickerDeclarationAppel.ValueChanged += new System.EventHandler(this.datePickerDeclarationAppel_ValueChanged);
            // 
            // datePickerMemoireAppelant
            // 
            this.datePickerMemoireAppelant.Location = new System.Drawing.Point(361, 51);
            this.datePickerMemoireAppelant.Name = "datePickerMemoireAppelant";
            this.datePickerMemoireAppelant.Size = new System.Drawing.Size(200, 26);
            this.datePickerMemoireAppelant.TabIndex = 1;
            this.datePickerMemoireAppelant.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            this.datePickerMemoireAppelant.ValueChanged += new System.EventHandler(this.datePickerMemoireAppelant_ValueChanged);
            // 
            // labelDepotDeclarationAppel
            // 
            this.labelDepotDeclarationAppel.AutoSize = true;
            this.labelDepotDeclarationAppel.Location = new System.Drawing.Point(12, 29);
            this.labelDepotDeclarationAppel.Name = "labelDepotDeclarationAppel";
            this.labelDepotDeclarationAppel.Size = new System.Drawing.Size(344, 19);
            this.labelDepotDeclarationAppel.TabIndex = 2;
            this.labelDepotDeclarationAppel.Text = "Sélectionner la date du dépôt de la déclaration d\'appel ";
            // 
            // labelDateLimiteDepotMemoireAppelant
            // 
            this.labelDateLimiteDepotMemoireAppelant.AutoSize = true;
            this.labelDateLimiteDepotMemoireAppelant.Location = new System.Drawing.Point(8, 114);
            this.labelDateLimiteDepotMemoireAppelant.Name = "labelDateLimiteDepotMemoireAppelant";
            this.labelDateLimiteDepotMemoireAppelant.Size = new System.Drawing.Size(235, 19);
            this.labelDateLimiteDepotMemoireAppelant.TabIndex = 5;
            this.labelDateLimiteDepotMemoireAppelant.Text = "Date limite de dépôt du mémoire de l\'appelant";
            // 
            // labelDateLimiteDepotMemoireAppelant2
            // 
            //this.labelDateLimiteDepotMemoireAppelant2.AutoSize = true;
            //this.labelDateLimiteDepotMemoireAppelant2.BackColor = System.Drawing.Color.Yellow;
            //this.labelDateLimiteDepotMemoireAppelant2.Location = new System.Drawing.Point(219, 114);
            //this.labelDateLimiteDepotMemoireAppelant2.Name = "labelDateLimiteDepotMemoireAppelant2";
            //this.labelDateLimiteDepotMemoireAppelant2.Size = new System.Drawing.Size(72, 19);
            //this.labelDateLimiteDepotMemoireAppelant2.TabIndex = 11;
            //this.labelDateLimiteDepotMemoireAppelant2.Text = "l\'appelant ";
            // 
            // labelDateLimiteDepotMemoireIntime
            // 
            this.labelDateLimiteDepotMemoireIntime.AutoSize = true;
            this.labelDateLimiteDepotMemoireIntime.Location = new System.Drawing.Point(358, 114);
            this.labelDateLimiteDepotMemoireIntime.Name = "labelDateLimiteDepotMemoireIntime";
            this.labelDateLimiteDepotMemoireIntime.Size = new System.Drawing.Size(235, 19);
            this.labelDateLimiteDepotMemoireIntime.TabIndex = 8;
            this.labelDateLimiteDepotMemoireIntime.Text = "Date limite de dépôt du mémoire de l\'intimé";
            // 
            // labelDateLimiteDepotMemoireIntime2
            // 
            //this.labelDateLimiteDepotMemoireIntime2.AutoSize = true;
            //this.labelDateLimiteDepotMemoireIntime2.BackColor = System.Drawing.Color.Green;
            //this.labelDateLimiteDepotMemoireIntime2.Location = new System.Drawing.Point(571, 114);
            //this.labelDateLimiteDepotMemoireIntime2.Name = "labelDateLimiteDepotMemoireIntime2";
            //this.labelDateLimiteDepotMemoireIntime2.Size = new System.Drawing.Size(53, 19);
            //this.labelDateLimiteDepotMemoireIntime2.TabIndex = 12;
            //this.labelDateLimiteDepotMemoireIntime2.Text = "l\'intimé";
            // 
            // labelDateDepotMemoireMisEnCause
            // 
            this.labelDateDepotMemoireMisEnCause.AutoSize = true;
            this.labelDateDepotMemoireMisEnCause.Location = new System.Drawing.Point(358, 163);
            this.labelDateDepotMemoireMisEnCause.Name = "labelDateDepotMemoireMisEnCause";
            this.labelDateDepotMemoireMisEnCause.Size = new System.Drawing.Size(301, 19);
            this.labelDateDepotMemoireMisEnCause.TabIndex = 9;
            this.labelDateDepotMemoireMisEnCause.Text = "Date limite de dépôt du mémoire des mec. / int.";
            // 
            // labelDepotMemoireAppelant
            // 
            this.labelDepotMemoireAppelant.Location = new System.Drawing.Point(357, 29);
            this.labelDepotMemoireAppelant.Margin = new System.Windows.Forms.Padding(0);
            this.labelDepotMemoireAppelant.Name = "labelDepotMemoireAppelant";
            this.labelDepotMemoireAppelant.Size = new System.Drawing.Size(288, 19);
            this.labelDepotMemoireAppelant.TabIndex = 10;
            this.labelDepotMemoireAppelant.Text = "Sélectionner la date de dépôt du mémoire de l\'appelant";
            //// 
            //// labelDepotMemoireAppelant2
            //// 
            //this.labelDepotMemoireAppelant2.AutoSize = true;
            //this.labelDepotMemoireAppelant2.BackColor = System.Drawing.Color.Yellow;
            //this.labelDepotMemoireAppelant2.Location = new System.Drawing.Point(626, 29);
            //this.labelDepotMemoireAppelant2.Name = "labelDepotMemoireAppelant2";
            //this.labelDepotMemoireAppelant2.Size = new System.Drawing.Size(68, 19);
            //this.labelDepotMemoireAppelant2.TabIndex = 13;
            //this.labelDepotMemoireAppelant2.Text = "l\'appelant";
            // 
            // dateLimiteDepotMemoireAppelant
            // 
            this.dateLimiteDepotMemoireAppelant.Location = new System.Drawing.Point(15, 136);
            this.dateLimiteDepotMemoireAppelant.Name = "dateLimiteDepotMemoireAppelant";
            this.dateLimiteDepotMemoireAppelant.ReadOnly = true;
            this.dateLimiteDepotMemoireAppelant.Size = new System.Drawing.Size(197, 26);
            this.dateLimiteDepotMemoireAppelant.TabIndex = 4;
            this.dateLimiteDepotMemoireAppelant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLimiteDepotMemoireIntime
            // 
            this.dateLimiteDepotMemoireIntime.Location = new System.Drawing.Point(361, 136);
            this.dateLimiteDepotMemoireIntime.Name = "dateLimiteDepotMemoireIntime";
            this.dateLimiteDepotMemoireIntime.ReadOnly = true;
            this.dateLimiteDepotMemoireIntime.Size = new System.Drawing.Size(197, 26);
            this.dateLimiteDepotMemoireIntime.TabIndex = 6;
            this.dateLimiteDepotMemoireIntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLimiteDepotMemoireMisEnCause
            // 
            this.dateLimiteDepotMemoireMisEnCause.Location = new System.Drawing.Point(361, 185);
            this.dateLimiteDepotMemoireMisEnCause.Name = "dateLimiteDepotMemoireMisEnCause";
            this.dateLimiteDepotMemoireMisEnCause.ReadOnly = true;
            this.dateLimiteDepotMemoireMisEnCause.Size = new System.Drawing.Size(197, 26);
            this.dateLimiteDepotMemoireMisEnCause.TabIndex = 7;
            this.dateLimiteDepotMemoireMisEnCause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reinitialiseMenuItem});
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(60, 24);
            this.MenuButton.Text = "Menu";
            // 
            // reinitialiseMenuItem
            // 
            this.reinitialiseMenuItem.Name = "reinitialiseMenuItem";
            this.reinitialiseMenuItem.Size = new System.Drawing.Size(231, 26);
            this.reinitialiseMenuItem.Text = "Reinitialiser les dates";
            this.reinitialiseMenuItem.Click += new System.EventHandler(this.reinitialiserLesDatesToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(778, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // DelaisDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 250);
            this.Controls.Add(this.labelDepotMemoireAppelant);
            //this.Controls.Add(this.labelDepotMemoireAppelant2);
            this.Controls.Add(this.labelDateDepotMemoireMisEnCause);
            this.Controls.Add(this.labelDateLimiteDepotMemoireIntime);
            //this.Controls.Add(this.labelDateLimiteDepotMemoireIntime2);
            this.Controls.Add(this.dateLimiteDepotMemoireMisEnCause);
            this.Controls.Add(this.dateLimiteDepotMemoireIntime);
            this.Controls.Add(this.labelDateLimiteDepotMemoireAppelant);
            //this.Controls.Add(this.labelDateLimiteDepotMemoireAppelant2);
            this.Controls.Add(this.dateLimiteDepotMemoireAppelant);
            this.Controls.Add(this.labelDepotDeclarationAppel);
            this.Controls.Add(this.datePickerMemoireAppelant);
            this.Controls.Add(this.datePickerDeclarationAppel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DelaisDates";
            this.Text = "Délais des dépots";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickerDeclarationAppel;
        private System.Windows.Forms.DateTimePicker datePickerMemoireAppelant;
        private System.Windows.Forms.TextBox dateLimiteDepotMemoireAppelant;
        private System.Windows.Forms.TextBox dateLimiteDepotMemoireIntime;
        private System.Windows.Forms.TextBox dateLimiteDepotMemoireMisEnCause;
        private System.Windows.Forms.Label labelDepotDeclarationAppel;
        private System.Windows.Forms.Label labelDateLimiteDepotMemoireAppelant;
        //private System.Windows.Forms.Label labelDateLimiteDepotMemoireAppelant2;
        private System.Windows.Forms.Label labelDateLimiteDepotMemoireIntime;
        //private System.Windows.Forms.Label labelDateLimiteDepotMemoireIntime2;
        private System.Windows.Forms.Label labelDateDepotMemoireMisEnCause;
        private System.Windows.Forms.Label labelDepotMemoireAppelant;
        //private System.Windows.Forms.Label labelDepotMemoireAppelant2;
        private System.Windows.Forms.ToolStripMenuItem MenuButton;
        private System.Windows.Forms.ToolStripMenuItem reinitialiseMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}

