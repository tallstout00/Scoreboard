
// This file has been generated by the GUI designer. Do not modify.
namespace Scoreboard
{
	public partial class Board
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Label label12;
		
		private global::Gtk.Label label13;
		
		private global::Gtk.Label label14;
		
		private global::Gtk.Label label15;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.Label labelLap1;
		
		private global::Gtk.Label labelLap2;
		
		private global::Gtk.Label labelLap3;
		
		private global::Gtk.Label labelLap4;
		
		private global::Gtk.Label labelLapNum1;
		
		private global::Gtk.Label labelLapNum2;
		
		private global::Gtk.Label labelLapNum3;
		
		private global::Gtk.Label labelLapNum4;
		
		private global::Gtk.Label labelName1;
		
		private global::Gtk.Label labelName2;
		
		private global::Gtk.Label labelName3;
		
		private global::Gtk.Label labelName4;
		
		private global::Gtk.Label labelPos1;
		
		private global::Gtk.Label labelPos2;
		
		private global::Gtk.Label labelPos3;
		
		private global::Gtk.Label labelPos4;
		
		private global::Gtk.Table table3;
		
		private global::Gtk.Image image93;
		
		private global::Gtk.Image image96;
		
		private global::Gtk.Image imageMills;
		
		private global::Gtk.Image imageMinOnes;
		
		private global::Gtk.Image imageMinTens;
		
		private global::Gtk.Image imageSecOnes;
		
		private global::Gtk.Image imageSecTens;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Scoreboard.Board
			this.WidthRequest = 800;
			this.HeightRequest = 480;
			this.Name = "Scoreboard.Board";
			this.Title = global::Mono.Unix.Catalog.GetString ("Board");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Scoreboard.Board.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(1)), true);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.table2 = new global::Gtk.Table (((uint)(5)), ((uint)(5)), true);
			this.table2.WidthRequest = 800;
			this.table2.HeightRequest = 240;
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(40));
			this.table2.ColumnSpacing = ((uint)(40));
			this.table2.BorderWidth = ((uint)(5));
			// Container child table2.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Best Lap");
			this.table2.Add (this.label10);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2 [this.label10]));
			w1.LeftAttach = ((uint)(2));
			w1.RightAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Player 1");
			this.table2.Add (this.label11);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.label11]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Player 2");
			this.table2.Add (this.label12);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.label12]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Player 3");
			this.table2.Add (this.label13);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.label13]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Player 4");
			this.table2.Add (this.label14);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.label14]));
			w5.TopAttach = ((uint)(4));
			w5.BottomAttach = ((uint)(5));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Current Position");
			this.table2.Add (this.label15);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.label15]));
			w6.LeftAttach = ((uint)(3));
			w6.RightAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Lap Number");
			this.table2.Add (this.label6);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2 [this.label6]));
			w7.LeftAttach = ((uint)(4));
			w7.RightAttach = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.table2.Add (this.label8);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2 [this.label8]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Player Name");
			this.table2.Add (this.label9);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2 [this.label9]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLap1 = new global::Gtk.Label ();
			this.labelLap1.Name = "labelLap1";
			this.table2.Add (this.labelLap1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLap1]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLap2 = new global::Gtk.Label ();
			this.labelLap2.Name = "labelLap2";
			this.table2.Add (this.labelLap2);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLap2]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLap3 = new global::Gtk.Label ();
			this.labelLap3.Name = "labelLap3";
			this.table2.Add (this.labelLap3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLap3]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLap4 = new global::Gtk.Label ();
			this.labelLap4.Name = "labelLap4";
			this.table2.Add (this.labelLap4);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLap4]));
			w13.TopAttach = ((uint)(4));
			w13.BottomAttach = ((uint)(5));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLapNum1 = new global::Gtk.Label ();
			this.labelLapNum1.Name = "labelLapNum1";
			this.labelLapNum1.LabelProp = global::Mono.Unix.Catalog.GetString ("1");
			this.table2.Add (this.labelLapNum1);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLapNum1]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(4));
			w14.RightAttach = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLapNum2 = new global::Gtk.Label ();
			this.labelLapNum2.Name = "labelLapNum2";
			this.labelLapNum2.LabelProp = global::Mono.Unix.Catalog.GetString ("1");
			this.table2.Add (this.labelLapNum2);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLapNum2]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.LeftAttach = ((uint)(4));
			w15.RightAttach = ((uint)(5));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLapNum3 = new global::Gtk.Label ();
			this.labelLapNum3.Name = "labelLapNum3";
			this.labelLapNum3.LabelProp = global::Mono.Unix.Catalog.GetString ("1");
			this.table2.Add (this.labelLapNum3);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLapNum3]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(4));
			w16.RightAttach = ((uint)(5));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLapNum4 = new global::Gtk.Label ();
			this.labelLapNum4.Name = "labelLapNum4";
			this.labelLapNum4.LabelProp = global::Mono.Unix.Catalog.GetString ("1");
			this.table2.Add (this.labelLapNum4);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLapNum4]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.LeftAttach = ((uint)(4));
			w17.RightAttach = ((uint)(5));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelName1 = new global::Gtk.Label ();
			this.labelName1.Name = "labelName1";
			this.table2.Add (this.labelName1);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelName1]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelName2 = new global::Gtk.Label ();
			this.labelName2.Name = "labelName2";
			this.table2.Add (this.labelName2);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelName2]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelName3 = new global::Gtk.Label ();
			this.labelName3.Name = "labelName3";
			this.table2.Add (this.labelName3);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelName3]));
			w20.TopAttach = ((uint)(3));
			w20.BottomAttach = ((uint)(4));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelName4 = new global::Gtk.Label ();
			this.labelName4.Name = "labelName4";
			this.table2.Add (this.labelName4);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelName4]));
			w21.TopAttach = ((uint)(4));
			w21.BottomAttach = ((uint)(5));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelPos1 = new global::Gtk.Label ();
			this.labelPos1.Name = "labelPos1";
			this.table2.Add (this.labelPos1);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelPos1]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.LeftAttach = ((uint)(3));
			w22.RightAttach = ((uint)(4));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelPos2 = new global::Gtk.Label ();
			this.labelPos2.Name = "labelPos2";
			this.table2.Add (this.labelPos2);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelPos2]));
			w23.TopAttach = ((uint)(2));
			w23.BottomAttach = ((uint)(3));
			w23.LeftAttach = ((uint)(3));
			w23.RightAttach = ((uint)(4));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelPos3 = new global::Gtk.Label ();
			this.labelPos3.Name = "labelPos3";
			this.table2.Add (this.labelPos3);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelPos3]));
			w24.TopAttach = ((uint)(3));
			w24.BottomAttach = ((uint)(4));
			w24.LeftAttach = ((uint)(3));
			w24.RightAttach = ((uint)(4));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelPos4 = new global::Gtk.Label ();
			this.labelPos4.Name = "labelPos4";
			this.table2.Add (this.labelPos4);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelPos4]));
			w25.TopAttach = ((uint)(4));
			w25.BottomAttach = ((uint)(5));
			w25.LeftAttach = ((uint)(3));
			w25.RightAttach = ((uint)(4));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add (this.table2);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.table2]));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.table3 = new global::Gtk.Table (((uint)(1)), ((uint)(7)), true);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(20));
			this.table3.BorderWidth = ((uint)(40));
			// Container child table3.Gtk.Table+TableChild
			this.image93 = new global::Gtk.Image ();
			this.image93.Name = "image93";
			this.image93.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./colon.png"));
			this.table3.Add (this.image93);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table3 [this.image93]));
			w27.LeftAttach = ((uint)(2));
			w27.RightAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.image96 = new global::Gtk.Image ();
			this.image96.Name = "image96";
			this.image96.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./period.bmp"));
			this.table3.Add (this.image96);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table3 [this.image96]));
			w28.LeftAttach = ((uint)(5));
			w28.RightAttach = ((uint)(6));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.imageMills = new global::Gtk.Image ();
			this.imageMills.Name = "imageMills";
			this.imageMills.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./zero.bmp"));
			this.table3.Add (this.imageMills);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table3 [this.imageMills]));
			w29.LeftAttach = ((uint)(6));
			w29.RightAttach = ((uint)(7));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.imageMinOnes = new global::Gtk.Image ();
			this.imageMinOnes.Name = "imageMinOnes";
			this.imageMinOnes.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./zero.bmp"));
			this.table3.Add (this.imageMinOnes);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table3 [this.imageMinOnes]));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.imageMinTens = new global::Gtk.Image ();
			this.imageMinTens.Name = "imageMinTens";
			this.imageMinTens.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./zero.bmp"));
			this.table3.Add (this.imageMinTens);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table3 [this.imageMinTens]));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.imageSecOnes = new global::Gtk.Image ();
			this.imageSecOnes.Name = "imageSecOnes";
			this.imageSecOnes.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./zero.bmp"));
			this.table3.Add (this.imageSecOnes);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table3 [this.imageSecOnes]));
			w32.LeftAttach = ((uint)(4));
			w32.RightAttach = ((uint)(5));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.imageSecTens = new global::Gtk.Image ();
			this.imageSecTens.Name = "imageSecTens";
			this.imageSecTens.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./zero.bmp"));
			this.table3.Add (this.imageSecTens);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table3 [this.imageSecTens]));
			w33.LeftAttach = ((uint)(3));
			w33.RightAttach = ((uint)(4));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add (this.table3);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1 [this.table3]));
			w34.TopAttach = ((uint)(1));
			w34.BottomAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 800;
			this.DefaultHeight = 480;
			this.Show ();
		}
	}
}
