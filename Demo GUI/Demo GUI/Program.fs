open System
open System.Drawing
open System.Windows.Forms

let form = new Form()
form.Visible <- true
form.Text <- "Test Form"
form.Size <- new Size(1000, 1000)

let box = new ComboBox()
let comboItems = new ComboBox.ObjectCollection(box)
comboItems.Add("One") |> ignore
comboItems.Add("Two") |> ignore
comboItems.Add("Three") |> ignore


let label = new Label()
label.Text <- "Hello World"
label.Location <- new Point(25, 25)

form.Controls.Add(label)
form.Controls.Add(box)

[<STAThread>]
Application.Run(form)