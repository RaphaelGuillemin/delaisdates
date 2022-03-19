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
            this.labelDateLimiteDepotMemoireIntime = new System.Windows.Forms.Label();
            this.labelDateDepotMemoireMisEnCause = new System.Windows.Forms.Label();
            this.labelDepotMemoireAppelant = new System.Windows.Forms.Label();
            this.dateLimiteDepotMemoireAppelant = new System.Windows.Forms.TextBox();
            this.dateLimiteDepotMemoireIntime = new System.Windows.Forms.TextBox();
            this.dateLimiteDepotMemoireMisEnCause = new System.Windows.Forms.TextBox();
            this.MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.reinitialiseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.joursFeries = new System.Windows.Forms.TabPage();
            this.buttonAddFerie = new System.Windows.Forms.Button();
            this.flowLayoutPanelnewFeries = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancelFeries = new System.Windows.Forms.Button();
            this.buttonOkFeries = new System.Windows.Forms.Button();
            this.flowLayoutPanelFeries = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelFeries = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeleteFerie = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.joursFeries.SuspendLayout();
            this.flowLayoutPanelFeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePickerDeclarationAppel
            // 
            this.datePickerDeclarationAppel.Location = new System.Drawing.Point(20, 34);
            this.datePickerDeclarationAppel.Name = "datePickerDeclarationAppel";
            this.datePickerDeclarationAppel.Size = new System.Drawing.Size(200, 26);
            this.datePickerDeclarationAppel.TabIndex = 0;
            this.datePickerDeclarationAppel.ValueChanged += new System.EventHandler(this.datePickerDeclarationAppel_ValueChanged);
            // 
            // datePickerMemoireAppelant
            // 
            this.datePickerMemoireAppelant.Location = new System.Drawing.Point(369, 34);
            this.datePickerMemoireAppelant.Name = "datePickerMemoireAppelant";
            this.datePickerMemoireAppelant.Size = new System.Drawing.Size(200, 26);
            this.datePickerMemoireAppelant.TabIndex = 1;
            this.datePickerMemoireAppelant.ValueChanged += new System.EventHandler(this.datePickerMemoireAppelant_ValueChanged);
            // 
            // labelDepotDeclarationAppel
            // 
            this.labelDepotDeclarationAppel.AutoSize = true;
            this.labelDepotDeclarationAppel.Location = new System.Drawing.Point(20, 12);
            this.labelDepotDeclarationAppel.Name = "labelDepotDeclarationAppel";
            this.labelDepotDeclarationAppel.Size = new System.Drawing.Size(344, 19);
            this.labelDepotDeclarationAppel.TabIndex = 2;
            this.labelDepotDeclarationAppel.Text = "Sélectionner la date du dépôt de la déclaration d\'appel ";
            // 
            // labelDateLimiteDepotMemoireAppelant
            // 
            this.labelDateLimiteDepotMemoireAppelant.AutoSize = true;
            this.labelDateLimiteDepotMemoireAppelant.Location = new System.Drawing.Point(16, 97);
            this.labelDateLimiteDepotMemoireAppelant.Name = "labelDateLimiteDepotMemoireAppelant";
            this.labelDateLimiteDepotMemoireAppelant.Size = new System.Drawing.Size(294, 19);
            this.labelDateLimiteDepotMemoireAppelant.TabIndex = 5;
            this.labelDateLimiteDepotMemoireAppelant.Text = "Date limite de dépôt du mémoire de l\'appelant";
            // 
            // labelDateLimiteDepotMemoireIntime
            // 
            this.labelDateLimiteDepotMemoireIntime.AutoSize = true;
            this.labelDateLimiteDepotMemoireIntime.Location = new System.Drawing.Point(366, 97);
            this.labelDateLimiteDepotMemoireIntime.Name = "labelDateLimiteDepotMemoireIntime";
            this.labelDateLimiteDepotMemoireIntime.Size = new System.Drawing.Size(279, 19);
            this.labelDateLimiteDepotMemoireIntime.TabIndex = 8;
            this.labelDateLimiteDepotMemoireIntime.Text = "Date limite de dépôt du mémoire de l\'intimé";
            // 
            // labelDateDepotMemoireMisEnCause
            // 
            this.labelDateDepotMemoireMisEnCause.AutoSize = true;
            this.labelDateDepotMemoireMisEnCause.Location = new System.Drawing.Point(366, 146);
            this.labelDateDepotMemoireMisEnCause.Name = "labelDateDepotMemoireMisEnCause";
            this.labelDateDepotMemoireMisEnCause.Size = new System.Drawing.Size(301, 19);
            this.labelDateDepotMemoireMisEnCause.TabIndex = 9;
            this.labelDateDepotMemoireMisEnCause.Text = "Date limite de dépôt du mémoire des mec. / int.";
            // 
            // labelDepotMemoireAppelant
            // 
            this.labelDepotMemoireAppelant.Location = new System.Drawing.Point(365, 12);
            this.labelDepotMemoireAppelant.Margin = new System.Windows.Forms.Padding(0);
            this.labelDepotMemoireAppelant.Name = "labelDepotMemoireAppelant";
            this.labelDepotMemoireAppelant.Size = new System.Drawing.Size(288, 19);
            this.labelDepotMemoireAppelant.TabIndex = 10;
            this.labelDepotMemoireAppelant.Text = "Sélectionner la date de dépôt du mémoire de l\'appelant";
            // 
            // dateLimiteDepotMemoireAppelant
            // 
            this.dateLimiteDepotMemoireAppelant.Location = new System.Drawing.Point(23, 119);
            this.dateLimiteDepotMemoireAppelant.Name = "dateLimiteDepotMemoireAppelant";
            this.dateLimiteDepotMemoireAppelant.ReadOnly = true;
            this.dateLimiteDepotMemoireAppelant.Size = new System.Drawing.Size(197, 26);
            this.dateLimiteDepotMemoireAppelant.TabIndex = 4;
            this.dateLimiteDepotMemoireAppelant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLimiteDepotMemoireIntime
            // 
            this.dateLimiteDepotMemoireIntime.Location = new System.Drawing.Point(369, 119);
            this.dateLimiteDepotMemoireIntime.Name = "dateLimiteDepotMemoireIntime";
            this.dateLimiteDepotMemoireIntime.ReadOnly = true;
            this.dateLimiteDepotMemoireIntime.Size = new System.Drawing.Size(197, 26);
            this.dateLimiteDepotMemoireIntime.TabIndex = 6;
            this.dateLimiteDepotMemoireIntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLimiteDepotMemoireMisEnCause
            // 
            this.dateLimiteDepotMemoireMisEnCause.Location = new System.Drawing.Point(369, 168);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainTab);
            this.tabControl.Controls.Add(this.joursFeries);
            this.tabControl.Location = new System.Drawing.Point(0, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(778, 247);
            this.tabControl.TabIndex = 11;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.labelDepotMemoireAppelant);
            this.mainTab.Controls.Add(this.datePickerDeclarationAppel);
            this.mainTab.Controls.Add(this.labelDepotDeclarationAppel);
            this.mainTab.Controls.Add(this.labelDateLimiteDepotMemoireAppelant);
            this.mainTab.Controls.Add(this.labelDateDepotMemoireMisEnCause);
            this.mainTab.Controls.Add(this.dateLimiteDepotMemoireIntime);
            this.mainTab.Controls.Add(this.dateLimiteDepotMemoireAppelant);
            this.mainTab.Controls.Add(this.labelDateLimiteDepotMemoireIntime);
            this.mainTab.Controls.Add(this.dateLimiteDepotMemoireMisEnCause);
            this.mainTab.Controls.Add(this.datePickerMemoireAppelant);
            this.mainTab.Location = new System.Drawing.Point(4, 28);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(770, 215);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Délais";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // joursFeries
            // 
            this.joursFeries.Controls.Add(this.buttonDeleteFerie);
            this.joursFeries.Controls.Add(this.buttonAddFerie);
            this.joursFeries.Controls.Add(this.flowLayoutPanelnewFeries);
            this.joursFeries.Controls.Add(this.buttonCancelFeries);
            this.joursFeries.Controls.Add(this.buttonOkFeries);
            this.joursFeries.Controls.Add(this.flowLayoutPanelFeries);
            this.joursFeries.Location = new System.Drawing.Point(4, 28);
            this.joursFeries.Name = "joursFeries";
            this.joursFeries.Padding = new System.Windows.Forms.Padding(3);
            this.joursFeries.Size = new System.Drawing.Size(770, 215);
            this.joursFeries.TabIndex = 1;
            this.joursFeries.Text = "Jours Fériés";
            this.joursFeries.UseVisualStyleBackColor = true;
            // 
            // buttonAddFerie
            // 
            this.buttonAddFerie.Location = new System.Drawing.Point(604, 7);
            this.buttonAddFerie.Name = "buttonAddFerie";
            this.buttonAddFerie.Size = new System.Drawing.Size(158, 30);
            this.buttonAddFerie.TabIndex = 4;
            this.buttonAddFerie.Text = "Ajouter un jour férié";
            this.buttonAddFerie.UseVisualStyleBackColor = true;
            this.buttonAddFerie.Click += new System.EventHandler(this.buttonAddFerie_Click);
            // 
            // buttonDeleteFerie
            // 
            this.buttonDeleteFerie.Location = new System.Drawing.Point(604, 44);
            this.buttonDeleteFerie.Name = "buttonDeleteFerie";
            this.buttonDeleteFerie.Size = new System.Drawing.Size(158, 32);
            this.buttonDeleteFerie.TabIndex = 5;
            this.buttonDeleteFerie.Click += new System.EventHandler(this.buttonDeleteFerie_Click);
            this.buttonDeleteFerie.Text = "Supprimer la sélection";
            this.buttonDeleteFerie.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelnewFeries
            // 
            this.flowLayoutPanelnewFeries.AutoScroll = true;
            this.flowLayoutPanelnewFeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelnewFeries.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelnewFeries.Location = new System.Drawing.Point(308, 0);
            this.flowLayoutPanelnewFeries.Name = "flowLayoutPanelnewFeries";
            this.flowLayoutPanelnewFeries.Size = new System.Drawing.Size(276, 187);
            this.flowLayoutPanelnewFeries.TabIndex = 3;
            this.flowLayoutPanelnewFeries.WrapContents = false;
            // 
            // buttonCancelFeries
            // 
            this.buttonCancelFeries.Location = new System.Drawing.Point(8, 193);
            this.buttonCancelFeries.Name = "buttonCancelFeries";
            this.buttonCancelFeries.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelFeries.TabIndex = 2;
            this.buttonCancelFeries.Text = "Annuler";
            this.buttonCancelFeries.UseVisualStyleBackColor = true;
            this.buttonCancelFeries.Click += new System.EventHandler(this.buttonCancelFeries_Click);
            // 
            // buttonOkFeries
            // 
            this.buttonOkFeries.Location = new System.Drawing.Point(107, 193);
            this.buttonOkFeries.Name = "buttonOkFeries";
            this.buttonOkFeries.Size = new System.Drawing.Size(75, 23);
            this.buttonOkFeries.TabIndex = 1;
            this.buttonOkFeries.Text = "Ok";
            this.buttonOkFeries.UseVisualStyleBackColor = true;
            this.buttonOkFeries.Click += new System.EventHandler(this.buttonOkFeries_Click);
            // 
            // flowLayoutPanelFeries
            // 
            this.flowLayoutPanelFeries.AutoScroll = true;
            this.flowLayoutPanelFeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelFeries.Controls.Add(this.tableLayoutPanelFeries);
            this.flowLayoutPanelFeries.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFeries.Location = new System.Drawing.Point(18, 0);
            this.flowLayoutPanelFeries.Name = "flowLayoutPanelFeries";
            this.flowLayoutPanelFeries.Size = new System.Drawing.Size(270, 187);
            this.flowLayoutPanelFeries.TabIndex = 0;
            this.flowLayoutPanelFeries.WrapContents = false;
            // 
            // tableLayoutPanelFeries
            // 
            this.tableLayoutPanelFeries.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelFeries.AutoSize = true;
            this.tableLayoutPanelFeries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanelFeries.ColumnCount = 2;
            this.tableLayoutPanelFeries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.5F));
            this.tableLayoutPanelFeries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4F));
            this.tableLayoutPanelFeries.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanelFeries.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelFeries.Name = "tableLayoutPanelFeries";
            this.tableLayoutPanelFeries.RowCount = 1;
            this.tableLayoutPanelFeries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFeries.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanelFeries.TabIndex = 0;
            // 
            // DelaisDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 285);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DelaisDates";
            this.Text = "Délais des dépots";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.joursFeries.ResumeLayout(false);
            this.flowLayoutPanelFeries.ResumeLayout(false);
            this.flowLayoutPanelFeries.PerformLayout();
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
        private System.Windows.Forms.Label labelDateLimiteDepotMemoireIntime;
        private System.Windows.Forms.Label labelDateDepotMemoireMisEnCause;
        private System.Windows.Forms.Label labelDepotMemoireAppelant;
        private System.Windows.Forms.ToolStripMenuItem MenuButton;
        private System.Windows.Forms.ToolStripMenuItem reinitialiseMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage joursFeries;
        private System.Windows.Forms.Button buttonCancelFeries;
        private System.Windows.Forms.Button buttonOkFeries;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFeries;
        private System.Windows.Forms.Button buttonAddFerie;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelnewFeries;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFeries;
        private System.Windows.Forms.Button buttonDeleteFerie;
    }
}

