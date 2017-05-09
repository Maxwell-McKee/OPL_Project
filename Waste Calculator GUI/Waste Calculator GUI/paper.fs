// Paper conversion funtions
module paper

// conversions to trees
let napToTree napkins = napkins / 900000.0
let paperToTree paper = paper / 83000.0
let reamsToTree reams = reams / 166.0
let tpToTree tp_rolls = tp_rolls / 400000.0
let towelToTree towls = towls / 200000.0
let acresToTree acres = acres * 1000.0

// conversions from trees
let treeToNap trees = trees * 900000.0
let treeToPaper trees = trees * 83000.0
let treeToTP trees = trees * 400000.0
let treeToTowel trees = trees * 200000.0
let treeToAcres trees = trees / 1000.0
let treeToReams trees = trees * 166.0
let treeToNapPack trees = trees * 4500.0
let treeToTPPack trees = trees * 5000.0
let treeToTowelPack trees = trees * 2500.0

let paperToPaper func1 measure1 func2 = 
  func1 measure1 |> func2
