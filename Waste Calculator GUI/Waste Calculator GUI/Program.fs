open System
open System.Drawing
open System.Windows.Forms

let form = new Form()
form.Visible <- true
form.Text <- "Waste Calculator"
form.Size <- new Size(1000, 750)
form.BackColor <- Color.ForestGreen

let pap = new Label()
pap.Text <- "Paper"
pap.Font <- new Font(FontFamily.GenericSansSerif, 26.0f)
pap.Size <- new Size(150, 100)
pap.Location <- new Point(25, 300)

let box = new ComboBox()
box.Size <- new Size (200, 100)
box.Location <- new Point(200, 375)
box.Items.Add("Paper") |> ignore
box.Items.Add("Napkins") |> ignore
box.Items.Add("Toilet Paper") |> ignore

let mat = new Label()
mat.Text <- "Material"
mat.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
mat.Size <- new Size(100, 50)
mat.Location <- new Point(50, 375)

let amt = new Label()
amt.Text <- "Amount"
amt.Font <- new Font(FontFamily.GenericSansSerif, 16.0f)
amt.Size <- new Size(100, 50)
amt.Location <- new Point(50, 425)

let quantity = new TextBox()
quantity.Text <- "Quantity"
quantity.Font <- new Font(FontFamily.GenericSansSerif, 14.0f)
quantity.Size <- new Size(200, 100)
quantity.Location <- new Point(200, 425)

let submit = new Button()
submit.Text <- "Submit"
submit.Font <- new Font(FontFamily.GenericSansSerif, 12.0f)
submit.Location <- new Point(410, 430)
submit.BackColor <- Color.AliceBlue

form.Controls.Add(mat)
form.Controls.Add(box)
form.Controls.Add(amt)
form.Controls.Add(pap)
form.Controls.Add(quantity)
form.Controls.Add(submit)

[<STAThread>]
Application.Run(form)