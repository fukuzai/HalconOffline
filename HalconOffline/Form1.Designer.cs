namespace HalconOffline
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.hSmartWindowControl1 = new HalconDotNet.HSmartWindowControl();
            this.hSmartWindowControl2 = new HalconDotNet.HSmartWindowControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hSmartWindowControl1
            // 
            this.hSmartWindowControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl1.HDoubleClickToFitContent = true;
            this.hSmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl1.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl1.HKeepAspectRatio = true;
            this.hSmartWindowControl1.HMoveContent = true;
            this.hSmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl1.Location = new System.Drawing.Point(23, 31);
            this.hSmartWindowControl1.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl1.Name = "hSmartWindowControl1";
            this.hSmartWindowControl1.Size = new System.Drawing.Size(532, 486);
            this.hSmartWindowControl1.TabIndex = 0;
            this.hSmartWindowControl1.WindowSize = new System.Drawing.Size(532, 486);
            // 
            // hSmartWindowControl2
            // 
            this.hSmartWindowControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl2.HDoubleClickToFitContent = true;
            this.hSmartWindowControl2.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl2.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl2.HKeepAspectRatio = true;
            this.hSmartWindowControl2.HMoveContent = true;
            this.hSmartWindowControl2.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl2.Location = new System.Drawing.Point(584, 31);
            this.hSmartWindowControl2.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl2.Name = "hSmartWindowControl2";
            this.hSmartWindowControl2.Size = new System.Drawing.Size(484, 486);
            this.hSmartWindowControl2.TabIndex = 1;
            this.hSmartWindowControl2.WindowSize = new System.Drawing.Size(484, 486);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "開く";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "実行";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "二値化閾値";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(744, 592);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1167, 711);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "終了";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 809);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hSmartWindowControl2);
            this.Controls.Add(this.hSmartWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HSmartWindowControl hSmartWindowControl1;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}

