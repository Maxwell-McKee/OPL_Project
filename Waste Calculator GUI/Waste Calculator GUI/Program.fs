open System
open System.Drawing
open System.Windows.Forms

let tableFont = new Font(FontFamily.GenericSansSerif, 16.0f)

let form = new Form()
form.Visible <- true
form.Text <- "Waste Calculator"
form.Size <- new Size(1000, 750)
form.BackColor <- Color.ForestGreen

let pap = new Label()
pap.Text <- "Paper"
pap.Font <- new Font(FontFamily.GenericSansSerif, 26.0f)
pap.Size <- new Size(150, 100)
pap.Location <- new Point(25, 30)

let mat = new Label()
mat.Text <- "Material"
mat.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
mat.Width <- 100
mat.Location <- new Point(50, 90)

let pBox = new ComboBox()
pBox.Size <- new Size (200, 100)
pBox.Location <- new Point(175, 90)
pBox.Font <- new Font(FontFamily.GenericSansSerif, 15.0f)
pBox.Items.Add "Paper" |> ignore
pBox.Items.Add "Napkins" |> ignore
pBox.Items.Add "Toilet Paper" |> ignore

let amt = new Label()
amt.Text <- "Amount"
amt.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
amt.Width <- 100
amt.Location <- new Point(450, 90)

let quantity = new TextBox()
quantity.Font <- new Font(FontFamily.GenericSansSerif, 14.0f)
quantity.Size <- new Size(200, 100)
quantity.Location <- new Point(550, 90)

let submit = new Button()
submit.Text <- "Submit"
submit.Font <- new Font(FontFamily.GenericSansSerif, 12.0f)
submit.Height <- 30
submit.Location <- new Point(750, 90)
submit.BackColor <- Color.AliceBlue
//submit.Click.Add(updateTable)

let unitsLabel = new Label()
unitsLabel.Text <- "Units"
unitsLabel.Font <- tableFont
unitsLabel.AutoSize <- true

let papLabel = new Label() 
papLabel.Text <- "Paper"
papLabel.Font <- tableFont
papLabel.AutoSize <- true

let napLabel = new Label() 
napLabel.Text <- "Napkins"
napLabel.Font <- tableFont
napLabel.AutoSize <- true

let tpLabel = new Label() 
tpLabel.Text <- "Toilet Paper"
tpLabel.Font <- tableFont
tpLabel.AutoSize <- true

let ptLabel = new Label() 
ptLabel.Text <- "Paper Towel"
ptLabel.Font <- tableFont
ptLabel.AutoSize <- true

let pTable = new TableLayoutPanel()
pTable.AutoSize <- true
pTable.AutoSizeMode <- AutoSizeMode.GrowAndShrink
pTable.Location <- new Point(50, 135)
pTable.Controls.Add(unitsLabel, 0, 0)
pTable.Controls.Add(papLabel, 0, 1)
pTable.Controls.Add(napLabel, 0, 2)
pTable.Controls.Add(tpLabel, 0, 3)
pTable.Controls.Add(ptLabel, 0, 4)
pTable.BorderStyle <- BorderStyle.FixedSingle
pTable.CellBorderStyle <- TableLayoutPanelCellBorderStyle.Single
pTable.BackColor <- Color.WhiteSmoke

form.Controls.Add mat
form.Controls.Add pBox
form.Controls.Add amt
form.Controls.Add pap
form.Controls.Add quantity
form.Controls.Add submit
form.Controls.Add pTable

[<STAThread>]
Application.Run(form)