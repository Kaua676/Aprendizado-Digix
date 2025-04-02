import {Sapo} from "./sapo.js";
import {Cobra} from "./cobra.js";

const sapo = new Sapo("Cururu", "Vermelho", 10, 5);
const cobra = new Cobra("Guri", "Vermelho", 10, 5);

sapo.procriar();
cobra.procriar();

console.log(sapo, cobra);