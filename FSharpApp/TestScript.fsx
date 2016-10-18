open System.Windows.Forms
open System.Drawing

let winForm = new Form()
winForm.Height <- 500
winForm.Width <- 800
for i in [1..9]
    do for j in [1..9]
        do (
            let t = new TextBox()
            t.Location <- new Point(10 + i * 20, 10 + j * 20)
            t.Height <- 20
            t.Width <- 20
            do winForm.Controls.Add(t))
do Application.Run(winForm)
    