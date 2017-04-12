open System
open System.Drawing
open System.Windows.Forms

let form = new Form()
form.Visible <- true
form.Text <- "Test Form"
form.Size <- new Size(1000, 1000)

let label = new Label()
label.Text <- "Hello World"
label.Location <- new Point(25, 25)

form.Controls.Add(label)

[<STAThread>]
Application.Run(form)