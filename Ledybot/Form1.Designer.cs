﻿namespace Ledybot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.l_dummy = new System.Windows.Forms.Label();
            this.tb_PID = new System.Windows.Forms.TextBox();
            this.lb_dummy2 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tb_PokemonToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_GiveAway = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Level = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Default = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Folder = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lv_log = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ditto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_Spanish = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(13, 13);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(100, 20);
            this.tb_IP.TabIndex = 0;
            this.tb_IP.Text = "192.168.178.48";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(135, 12);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(34, 20);
            this.tb_Port.TabIndex = 1;
            this.tb_Port.Text = "8000";
            // 
            // l_dummy
            // 
            this.l_dummy.AutoSize = true;
            this.l_dummy.Location = new System.Drawing.Point(119, 16);
            this.l_dummy.Name = "l_dummy";
            this.l_dummy.Size = new System.Drawing.Size(10, 13);
            this.l_dummy.TabIndex = 2;
            this.l_dummy.Text = ":";
            // 
            // tb_PID
            // 
            this.tb_PID.Location = new System.Drawing.Point(191, 12);
            this.tb_PID.Name = "tb_PID";
            this.tb_PID.Size = new System.Drawing.Size(19, 20);
            this.tb_PID.TabIndex = 3;
            this.tb_PID.Text = "2b";
            // 
            // lb_dummy2
            // 
            this.lb_dummy2.AutoSize = true;
            this.lb_dummy2.Location = new System.Drawing.Point(175, 16);
            this.lb_dummy2.Name = "lb_dummy2";
            this.lb_dummy2.Size = new System.Drawing.Size(10, 13);
            this.lb_dummy2.TabIndex = 4;
            this.lb_dummy2.Text = "-";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(216, 9);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tb_PokemonToFind
            // 
            this.tb_PokemonToFind.Location = new System.Drawing.Point(13, 70);
            this.tb_PokemonToFind.Name = "tb_PokemonToFind";
            this.tb_PokemonToFind.Size = new System.Drawing.Size(100, 20);
            this.tb_PokemonToFind.TabIndex = 6;
            this.tb_PokemonToFind.Text = "Ledyba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Deposited Pokemon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "GiveAway Pokemon:";
            // 
            // tb_GiveAway
            // 
            this.tb_GiveAway.Location = new System.Drawing.Point(12, 122);
            this.tb_GiveAway.Name = "tb_GiveAway";
            this.tb_GiveAway.Size = new System.Drawing.Size(100, 20);
            this.tb_GiveAway.TabIndex = 9;
            this.tb_GiveAway.Text = "Ditto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Level:";
            // 
            // tb_Level
            // 
            this.tb_Level.Location = new System.Drawing.Point(128, 122);
            this.tb_Level.Name = "tb_Level";
            this.tb_Level.Size = new System.Drawing.Size(33, 20);
            this.tb_Level.TabIndex = 11;
            this.tb_Level.Text = "91";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Default .pk7:";
            // 
            // tb_Default
            // 
            this.tb_Default.Location = new System.Drawing.Point(12, 176);
            this.tb_Default.Name = "tb_Default";
            this.tb_Default.Size = new System.Drawing.Size(354, 20);
            this.tb_Default.TabIndex = 13;
            this.tb_Default.Text = "C:/GiveAway/6IV.pk7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Specific .pk7 folder:";
            // 
            // tb_Folder
            // 
            this.tb_Folder.Location = new System.Drawing.Point(12, 219);
            this.tb_Folder.Name = "tb_Folder";
            this.tb_Folder.Size = new System.Drawing.Size(354, 20);
            this.tb_Folder.TabIndex = 15;
            this.tb_Folder.Text = "C:/GiveAway/";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(167, 120);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(58, 23);
            this.btn_Start.TabIndex = 16;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(233, 120);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(58, 23);
            this.btn_Stop.TabIndex = 17;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lv_log
            // 
            this.lv_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Trainer,
            this.Ditto,
            this.Country,
            this.SubCountry});
            this.lv_log.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_log.Location = new System.Drawing.Point(13, 246);
            this.lv_log.Name = "lv_log";
            this.lv_log.Size = new System.Drawing.Size(353, 262);
            this.lv_log.TabIndex = 18;
            this.lv_log.UseCompatibleStateImageBehavior = false;
            this.lv_log.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 40;
            // 
            // Trainer
            // 
            this.Trainer.Text = "Trainer";
            // 
            // Ditto
            // 
            this.Ditto.Text = "Ditto";
            this.Ditto.Width = 50;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            // 
            // SubCountry
            // 
            this.SubCountry.Text = "SubCountry";
            // 
            // cb_Spanish
            // 
            this.cb_Spanish.AutoSize = true;
            this.cb_Spanish.Location = new System.Drawing.Point(297, 122);
            this.cb_Spanish.Name = "cb_Spanish";
            this.cb_Spanish.Size = new System.Drawing.Size(64, 17);
            this.cb_Spanish.TabIndex = 19;
            this.cb_Spanish.Text = "Spanish";
            this.cb_Spanish.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 520);
            this.Controls.Add(this.cb_Spanish);
            this.Controls.Add(this.lv_log);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.tb_Folder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Default);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Level);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_GiveAway);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_PokemonToFind);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lb_dummy2);
            this.Controls.Add(this.tb_PID);
            this.Controls.Add(this.l_dummy);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.tb_IP);
            this.Name = "MainForm";
            this.Text = "Ledybot v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Label l_dummy;
        private System.Windows.Forms.TextBox tb_PID;
        private System.Windows.Forms.Label lb_dummy2;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox tb_PokemonToFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_GiveAway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Level;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Default;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Folder;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ListView lv_log;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Trainer;
        private System.Windows.Forms.ColumnHeader Ditto;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader SubCountry;
        private System.Windows.Forms.CheckBox cb_Spanish;
    }
}

