module paper

let napToTree napkins = napkins / 900.0
let paperToReams paper = paper / 500.0
let reamsToPaper reams = reams * 500.0
let paperToTrees paper = (paper / 500.0) * 0.06

let treeToNap trees = trees * 900.0
let treesToPaper trees = (trees / 0.06) * 500.0

let paperToPaper func1 measure1 func2 = 
  func1 measure1 |> func2
