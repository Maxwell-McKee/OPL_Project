open System
open System.Drawing
open System.Windows.Forms

let tableFont = new Font(FontFamily.GenericSansSerif, 16.0f)

let mutable trees = 0.0

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
pBox.Items.Add "Paper Towels" |> ignore
pBox.SelectedText <- "Paper"

let amt = new Label()
amt.Text <- "Amount"
amt.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
amt.Width <- 100
amt.Location <- new Point(450, 90)

let mutable quantity = new TextBox()
quantity.Font <- new Font(FontFamily.GenericSansSerif, 14.0f)
quantity.Size <- new Size(200, 100)
quantity.Location <- new Point(550, 90)

let unitsLabel = new Label()
unitsLabel.Text <- "Units"
unitsLabel.Font <- tableFont
unitsLabel.AutoSize <- true

let mutable papLabel = new Label() 
papLabel.Text <- "Paper"
papLabel.Font <- tableFont
papLabel.AutoSize <- true

let mutable napLabel = new Label() 
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

let piecesLabel = new Label()
piecesLabel.Text <- "Pieces"
piecesLabel.Font <- tableFont

let packLabel = new Label()
packLabel.Text <- "Standard Packs"
packLabel.Font <- tableFont

let treesLabel = new Label()
treesLabel.Text <- "Trees"
treesLabel.Font <- tableFont

let acresLabel = new Label()
acresLabel.Text <- "Acres of Plantation"
acresLabel.Font <- tableFont

let mutable papValue = new Label()
papValue.Font <- tableFont
papValue.Text <- "0"
papValue.AutoSize <- true

let napValue = new Label()
napValue.Font <- tableFont
napValue.Text <- "0"
napValue.AutoSize <- true

let tpValue = new Label()
tpValue.Font <- tableFont
tpValue.Text <- "0"
tpValue.AutoSize <- true

let ptValue = new Label()
ptValue.Font <- tableFont
ptValue.Text <- "0"
ptValue.AutoSize <- true


let pTable = new TableLayoutPanel()
pTable.AutoSize <- true
pTable.AutoSizeMode <- AutoSizeMode.GrowAndShrink
pTable.Location <- new Point(50, 135)
pTable.Controls.Add(unitsLabel, 0, 0)
pTable.Controls.Add(piecesLabel, 1, 0)
pTable.Controls.Add(packLabel, 2, 0)
pTable.Controls.Add(treesLabel, 3, 0)
pTable.Controls.Add(acresLabel, 4, 0)
pTable.Controls.Add(papLabel, 0, 1)
pTable.Controls.Add(napLabel, 0, 2)
pTable.Controls.Add(tpLabel, 0, 3)
pTable.Controls.Add(ptLabel, 0, 4)
pTable.Controls.Add(papValue, 1, 1)
pTable.Controls.Add(napValue, 1, 2)
pTable.Controls.Add(tpValue, 1, 3)
pTable.Controls.Add(ptValue, 1, 4)
pTable.BorderStyle <- BorderStyle.FixedSingle
pTable.CellBorderStyle <- TableLayoutPanelCellBorderStyle.Single
pTable.BackColor <- Color.WhiteSmoke

let treeValue quantity = 
    match pBox.Text with
    | "Paper" -> quantity |> paper.paperToTree 
    | "Napkins" -> quantity |> paper.napToTree 
    | "Toilet Paper" -> quantity |> paper.paperToTree 
    | "Paper Towel" -> quantity |> paper.paperToTree 
    | _ -> 1.0

let pSubmit = new Button()
pSubmit.Text <- "Submit"
pSubmit.Font <- new Font(FontFamily.GenericSansSerif, 12.0f)
pSubmit.Height <- 30
pSubmit.Location <- new Point(750, 90)
pSubmit.BackColor <- Color.AliceBlue
pSubmit.Click.Add(fun _ -> trees <- treeValue (quantity.Text |> float)) 
pSubmit.Click.Add(fun _ -> printfn "Quantity: %s \n Trees: %f \n pBox: %s" quantity.Text trees pBox.Text)
pSubmit.Click.Add(fun _ -> papValue.Text <- trees |> paper.treeToPaper |> string )
pSubmit.Click.Add(fun _ -> napValue.Text <- trees |> paper.treeToNap |> string)
pSubmit.Click.Add(fun _ -> tpValue.Text <- trees |> paper.treeToTP |> string)
pSubmit.Click.Add(fun _ -> ptValue.Text <- trees |> paper.treeToTowel |> string)
pSubmit.Click.Add(fun _ -> printfn "Pap: %s \nNap: %s \ntp: %s \npt: %s \n" papValue.Text napValue.Text tpValue.Text ptValue.Text)
pSubmit.Click.Add(fun _ -> form.Refresh())

form.Controls.Add mat
form.Controls.Add pBox
form.Controls.Add amt
form.Controls.Add pap
form.Controls.Add quantity
form.Controls.Add pSubmit
form.Controls.Add pTable

[<STAThread>]
Application.Run(form)