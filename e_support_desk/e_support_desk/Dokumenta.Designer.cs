
namespace e_support_desk
{
    partial class Dokumenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label problemiLabel;
            System.Windows.Forms.Label zgjidhjaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dokumenta));
            this.e_supportDataSet = new e_support_desk.e_supportDataSet();
            this.dokumentimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokumentimTableAdapter = new e_support_desk.e_supportDataSetTableAdapters.dokumentimTableAdapter();
            this.tableAdapterManager = new e_support_desk.e_supportDataSetTableAdapters.TableAdapterManager();
            this.dokumentimBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dokumentimBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.problemiTextBox = new System.Windows.Forms.TextBox();
            this.zgjidhjaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            problemiLabel = new System.Windows.Forms.Label();
            zgjidhjaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentimBindingNavigator)).BeginInit();
            this.dokumentimBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // problemiLabel
            // 
            problemiLabel.AutoSize = true;
            problemiLabel.Location = new System.Drawing.Point(39, 159);
            problemiLabel.Name = "problemiLabel";
            problemiLabel.Size = new System.Drawing.Size(74, 20);
            problemiLabel.TabIndex = 1;
            problemiLabel.Text = "Problemi:";
            // 
            // zgjidhjaLabel
            // 
            zgjidhjaLabel.AutoSize = true;
            zgjidhjaLabel.Location = new System.Drawing.Point(39, 249);
            zgjidhjaLabel.Name = "zgjidhjaLabel";
            zgjidhjaLabel.Size = new System.Drawing.Size(68, 20);
            zgjidhjaLabel.TabIndex = 3;
            zgjidhjaLabel.Text = "Zgjidhja:";
            // 
            // e_supportDataSet
            // 
            this.e_supportDataSet.DataSetName = "e_supportDataSet";
            this.e_supportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dokumentimBindingSource
            // 
            this.dokumentimBindingSource.DataMember = "dokumentim";
            this.dokumentimBindingSource.DataSource = this.e_supportDataSet;
            // 
            // dokumentimTableAdapter
            // 
            this.dokumentimTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ceshtja1TableAdapter = null;
            this.tableAdapterManager.ceshtjaTableAdapter = null;
            this.tableAdapterManager.dokumentimTableAdapter = this.dokumentimTableAdapter;
            this.tableAdapterManager.fatureTableAdapter = null;
            this.tableAdapterManager.klientiTableAdapter = null;
            this.tableAdapterManager.krk_sh_afatiTableAdapter = null;
            this.tableAdapterManager.pajisjaTableAdapter = null;
            this.tableAdapterManager.prioritetiTableAdapter = null;
            this.tableAdapterManager.punonjesiTableAdapter = null;
            this.tableAdapterManager.roliTableAdapter = null;
            this.tableAdapterManager.sherbimiTableAdapter = null;
            this.tableAdapterManager.shitjeTableAdapter = null;
            this.tableAdapterManager.statusiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = e_support_desk.e_supportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dokumentimBindingNavigator
            // 
            this.dokumentimBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dokumentimBindingNavigator.BindingSource = this.dokumentimBindingSource;
            this.dokumentimBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dokumentimBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dokumentimBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dokumentimBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dokumentimBindingNavigatorSaveItem});
            this.dokumentimBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dokumentimBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dokumentimBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dokumentimBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dokumentimBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dokumentimBindingNavigator.Name = "dokumentimBindingNavigator";
            this.dokumentimBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dokumentimBindingNavigator.Size = new System.Drawing.Size(1254, 33);
            this.dokumentimBindingNavigator.TabIndex = 0;
            this.dokumentimBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // dokumentimBindingNavigatorSaveItem
            // 
            this.dokumentimBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dokumentimBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dokumentimBindingNavigatorSaveItem.Image")));
            this.dokumentimBindingNavigatorSaveItem.Name = "dokumentimBindingNavigatorSaveItem";
            this.dokumentimBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.dokumentimBindingNavigatorSaveItem.Text = "Save Data";
            this.dokumentimBindingNavigatorSaveItem.Click += new System.EventHandler(this.dokumentimBindingNavigatorSaveItem_Click);
            // 
            // problemiTextBox
            // 
            this.problemiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokumentimBindingSource, "problemi", true));
            this.problemiTextBox.Location = new System.Drawing.Point(134, 156);
            this.problemiTextBox.Multiline = true;
            this.problemiTextBox.Name = "problemiTextBox";
            this.problemiTextBox.Size = new System.Drawing.Size(415, 58);
            this.problemiTextBox.TabIndex = 2;
            // 
            // zgjidhjaTextBox
            // 
            this.zgjidhjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokumentimBindingSource, "zgjidhja", true));
            this.zgjidhjaTextBox.Location = new System.Drawing.Point(134, 246);
            this.zgjidhjaTextBox.Multiline = true;
            this.zgjidhjaTextBox.Name = "zgjidhjaTextBox";
            this.zgjidhjaTextBox.Size = new System.Drawing.Size(415, 322);
            this.zgjidhjaTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dokumentari i zgjidhjeve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Statistika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nr. mesatar i diteve te zgjidhjes se ceshtjes para afatit:";
            // 
            // txt_dite
            // 
            this.txt_dite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dite.Location = new System.Drawing.Point(273, 219);
            this.txt_dite.Name = "txt_dite";
            this.txt_dite.ReadOnly = true;
            this.txt_dite.Size = new System.Drawing.Size(59, 35);
            this.txt_dite.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "dite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numri i ceshtjeve per kategori prioriteti:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prioriteti 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prioriteti 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Prioriteti 3:";
            // 
            // txt_p1
            // 
            this.txt_p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p1.Location = new System.Drawing.Point(272, 346);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.ReadOnly = true;
            this.txt_p1.Size = new System.Drawing.Size(59, 35);
            this.txt_p1.TabIndex = 16;
            // 
            // txt_p2
            // 
            this.txt_p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p2.Location = new System.Drawing.Point(273, 387);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.ReadOnly = true;
            this.txt_p2.Size = new System.Drawing.Size(59, 35);
            this.txt_p2.TabIndex = 17;
            // 
            // txt_p3
            // 
            this.txt_p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p3.Location = new System.Drawing.Point(273, 428);
            this.txt_p3.Name = "txt_p3";
            this.txt_p3.ReadOnly = true;
            this.txt_p3.Size = new System.Drawing.Size(59, 35);
            this.txt_p3.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_p3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_p2);
            this.panel1.Controls.Add(this.txt_dite);
            this.panel1.Controls.Add(this.txt_p1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(613, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 507);
            this.panel1.TabIndex = 19;
            // 
            // Dokumenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(problemiLabel);
            this.Controls.Add(this.problemiTextBox);
            this.Controls.Add(zgjidhjaLabel);
            this.Controls.Add(this.zgjidhjaTextBox);
            this.Controls.Add(this.dokumentimBindingNavigator);
            this.Name = "Dokumenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dokumenta";
            this.Load += new System.EventHandler(this.Dokumenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_supportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentimBindingNavigator)).EndInit();
            this.dokumentimBindingNavigator.ResumeLayout(false);
            this.dokumentimBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private e_supportDataSet e_supportDataSet;
        private System.Windows.Forms.BindingSource dokumentimBindingSource;
        private e_supportDataSetTableAdapters.dokumentimTableAdapter dokumentimTableAdapter;
        private e_supportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dokumentimBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dokumentimBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox problemiTextBox;
        private System.Windows.Forms.TextBox zgjidhjaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_p1;
        private System.Windows.Forms.TextBox txt_p2;
        private System.Windows.Forms.TextBox txt_p3;
        private System.Windows.Forms.Panel panel1;
    }
}