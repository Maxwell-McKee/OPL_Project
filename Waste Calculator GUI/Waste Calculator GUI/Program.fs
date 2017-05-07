open System
open System.Drawing
open System.Windows.Forms

let napToTree napkins = napkins / 900000.0
let paperToTree paper = paper / 83000
let reamsToTree reams = reams / 166
let tpToTree tp_rolls = tp_rolls / 400000
let towelToTree towls = towls / 200000
let acresToTree acres = acres * 1000

let treeToNap trees = trees * 900000.0
let treeToPaper trees = trees * 83000
let treeToReams trees = trees * 166
let treeToTP trees = trees * 400000
let treeToTowel trees = trees * 200000
let treeToAcres trees = trees / 1000

let paperToPaper func1 measure1 func2 = 
  func1 measure1 |> func2

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

let papLabel = new Label() 
papLabel.Text <- "Paper"
papLabel.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
papLabel.AutoSize <- true

let napLabel = new Label() 
napLabel.Text <- "Napkins"
napLabel.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
napLabel.AutoSize <- true

let tpLabel = new Label() 
tpLabel.Text <- "Toilet Paper"
tpLabel.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
tpLabel.AutoSize <- true

let ptLabel = new Label() 
ptLabel.Text <- "Paper Towel"
ptLabel.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
ptLabel.AutoSize <- true

let pTable = new TableLayoutPanel()
pTable.AutoSize <- true
pTable.AutoSizeMode <- AutoSizeMode.GrowAndShrink
pTable.Location <- new Point(50, 135)
pTable.Controls.Add(papLabel, 0, 0)
pTable.Controls.Add(napLabel, 0, 1)
pTable.Controls.Add(tpLabel, 0, 2)
pTable.Controls.Add(ptLabel, 0, 3)
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