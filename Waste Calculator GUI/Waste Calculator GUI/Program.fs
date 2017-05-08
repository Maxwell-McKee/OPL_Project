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
piecesLabel.Width <- 200
piecesLabel.Font <- tableFont

let packLabel = new Label()
packLabel.Text <- "Standard Packs"
packLabel.Width <- 200
packLabel.Font <- tableFont

let treesLabel = new Label()
treesLabel.Text <- "Trees"
treesLabel.Font <- tableFont

let acresLabel = new Label()
acresLabel.Text <- "Acres of Plantation"
acresLabel.Font <- tableFont

let papValue = new Label()
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

let papPack = new Label()
papPack.Font <- tableFont
papPack.Text <- "0"

let napPack = new Label()
napPack.Font <- tableFont
napPack.Text <- "0"

let tpPack = new Label()
tpPack.Font <- tableFont
tpPack.Text <- "0"

let ptPack = new Label()
ptPack.Font <- tableFont
ptPack.Text <- "0"

let pTable = new TableLayoutPanel()
pTable.AutoSize <- true
pTable.AutoSizeMode <- AutoSizeMode.GrowOnly
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
pTable.Controls.Add(papPack, 2, 1)
pTable.Controls.Add(napPack, 2, 2)
pTable.Controls.Add(tpPack, 2 , 3)
pTable.Controls.Add(ptPack, 2, 4)
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
pSubmit.Click.Add(fun _ -> trees <- quantity.Text |> float |> treeValue) 
pSubmit.Click.Add(fun _ -> printfn "Quantity: %s \n Trees: %f \n pBox: %s" quantity.Text trees pBox.Text)
pSubmit.Click.Add(fun _ -> papValue.Text <- trees |> paper.treeToPaper |> string )
pSubmit.Click.Add(fun _ -> napValue.Text <- trees |> paper.treeToNap |> string)
pSubmit.Click.Add(fun _ -> tpValue.Text <- trees |> paper.treeToTP |> string)
pSubmit.Click.Add(fun _ -> ptValue.Text <- trees |> paper.treeToTowel |> string)
pSubmit.Click.Add(fun _ -> papPack.Text <- trees |> paper.treeToReams |> string )
pSubmit.Click.Add(fun _ -> napPack.Text <- trees |> paper.treeToNapPack |> string)
pSubmit.Click.Add(fun _ -> tpPack.Text <- trees |> paper.treeToTPPack |> string)
pSubmit.Click.Add(fun _ -> ptPack.Text <- trees |> paper.treeToTowelPack |> string)
pSubmit.Click.Add(fun _ -> printfn "Pap: %s \nNap: %s \ntp: %s \npt: %s \n" papValue.Text napValue.Text tpValue.Text ptValue.Text)
pSubmit.Click.Add(fun _ -> form.Refresh())

form.Controls.Add mat
form.Controls.Add pBox
form.Controls.Add amt
form.Controls.Add pap
form.Controls.Add quantity
form.Controls.Add pSubmit
form.Controls.Add pTable

//let mutable cups = 0.0

let unit = new Label()
unit.Text <- "Unit"
unit.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
unit.Width <- 100
unit.Location <- new Point(70, 378)

let wat = new Label()
wat.Text <- "Water"
wat.Font <- new Font(FontFamily.GenericSansSerif, 26.0f)
wat.Size <- new Size(150, 100)
wat.Location <- new Point(25, 320)

let wBox = new ComboBox()
wBox.Size <- new Size (200, 100)
wBox.Location <- new Point(175, 375)
wBox.Font <- new Font(FontFamily.GenericSansSerif, 15.0f)
wBox.Items.Add "Cups" |> ignore
wBox.Items.Add "Gallons" |> ignore
wBox.Items.Add "Liters" |> ignore
wBox.Items.Add "Bathtubs" |> ignore
wBox.Items.Add "SwimmingPools" |> ignore
wBox.SelectedText <- "Cups"

let amt2 = new Label()
amt2.Text <- "Amount"
amt2.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
amt2.Width <- 100
amt2.Location <- new Point(450, 378)

let mutable quantity2 = new TextBox()
quantity2.Font <- new Font(FontFamily.GenericSansSerif, 14.0f)
quantity2.Size <- new Size(200, 100)
quantity2.Location <- new Point(550, 375)

let unitsLabel2 = new Label()
unitsLabel2.Text <- "Units"
unitsLabel2.Font <- tableFont
unitsLabel2.AutoSize <- true

let mutable cupLabel = new Label() 
cupLabel.Text <- "Cups"
cupLabel.Font <- tableFont
cupLabel.AutoSize <- true

let mutable galLabel = new Label() 
galLabel.Text <- "Gallons"
galLabel.Font <- tableFont
galLabel.AutoSize <- true

let mutable litLabel = new Label() 
litLabel.Text <- "Liters"
litLabel.Font <- tableFont
litLabel.AutoSize <- true

let mutable bathLabel = new Label() 
bathLabel.Text <- "Bathtubs"
bathLabel.Font <- tableFont
bathLabel.AutoSize <- true

let mutable poolLabel = new Label() 
poolLabel.Text <- "Swimming Pools"
poolLabel.Font <- tableFont
poolLabel.AutoSize <- true

let cupValue = new Label()
cupValue.Font <- tableFont
cupValue.Text <- "0"
cupValue.AutoSize <- true

let galValue = new Label()
galValue.Font <- tableFont
galValue.Text <- "0"
galValue.AutoSize <- true

let litValue = new Label()
litValue.Font <- tableFont
litValue.Text <- "0"
litValue.AutoSize <- true

let bathValue = new Label()
bathValue.Font <- tableFont
bathValue.Text <- "0"
bathValue.AutoSize <- true

let poolValue = new Label()
poolValue.Font <- tableFont
poolValue.Text <- "0"
poolValue.AutoSize <- true

let cupsValue quantity2 = 
    match wBox.Text with
    | "Gallons" -> quantity2 |> water.gallonsToCups 
    | "Liters" -> quantity2 |> water.litersToCups 
    | "Bathtubs" -> quantity2 |> water.bathtubsToCups 
    | "Swimming Pools" -> quantity2 |> water.swimmingPoolsToCups 
    | _ -> 1.0

let wTable = new TableLayoutPanel()
wTable.AutoSize <- true
wTable.AutoSizeMode <- AutoSizeMode.GrowOnly
wTable.Location <- new Point(50, 450)
wTable.Controls.Add(unitsLabel2, 0, 0)
wTable.Controls.Add(cupLabel, 1, 0)
wTable.Controls.Add(galLabel, 2, 0)
wTable.Controls.Add(litLabel, 3, 0)
wTable.Controls.Add(bathLabel, 4, 0)
wTable.Controls.Add(poolLabel, 5, 0)
wTable.Controls.Add(cupValue, 1, 1)
wTable.Controls.Add(galValue, 2, 1)
wTable.Controls.Add(litValue, 3, 1)
wTable.Controls.Add(bathValue, 4, 1)
wTable.Controls.Add(poolValue, 5, 1)
wTable.BorderStyle <- BorderStyle.FixedSingle
wTable.CellBorderStyle <- TableLayoutPanelCellBorderStyle.Single
wTable.BackColor <- Color.WhiteSmoke


(*
let wSubmit = new Button()
wSubmit.Text <- "Submit"
wSubmit.Font <- new Font(FontFamily.GenericSansSerif, 12.0f)
wSubmit.Height <- 30
wSubmit.Location <- new Point(750, 375)
wSubmit.BackColor <- Color.AliceBlue
wSubmit.Click.Add(fun _ -> cups <- quantity2.Text |> float |> treeValue) 
wSubmit.Click.Add(fun _ -> printfn "Quantity: %s \n Cups: %f \n wBox: %s" quantity.Text cups wBox.Text)
wSubmit.Click.Add(fun _ -> papValue.Text <- cups |> water.cupsToGallons |> string )
wSubmit.Click.Add(fun _ -> napValue.Text <- cups |> water.cupsToLiters |> string)
wSubmit.Click.Add(fun _ -> tpValue.Text <- cups |> water.cupsToBathtubs |> string)
wSubmit.Click.Add(fun _ -> ptValue.Text <- cups |> water.cupsToSwimmingPools |> string)
//wSubmit.Click.Add(fun _ -> printfn "Pap: %s \nNap: %s \ntp: %s \npt: %s \n" cupValue.Text galValue.Text litValue.Text bathValue.Text poolValue.Text)
wSubmit.Click.Add(fun _ -> form.Refresh())
*)

form.Controls.Add unit
form.Controls.Add wBox
form.Controls.Add amt2
form.Controls.Add wat
form.Controls.Add quantity2
//form.Controls.Add wSubmit
form.Controls.Add wTable


[<STAThread>]
Application.Run(form)
