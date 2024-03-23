class ChemicalBank{
    public float getBoilingPoint(string chemical){
        switch(chemical.ToLower()   ){
            case "water":
               return 100.0f;

            case "benzene":
                return 80.1f;

            case "ethanol":
                return 78.37f;

            default:
                return 0.0f;

        }
    }
    public string getMolecularFormula(string chemical){
        switch(chemical.ToLower()   ){
            case "water":
               return "H2O";

            case "benzene":
                return "C6H6";

            case "ethanol":
                return "C2H5OH";
                
            default:
                return "Unknown";

        }
    }
}