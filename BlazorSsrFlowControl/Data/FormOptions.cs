using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BlazorSsrFlowControl.Data
{
    public class FormOptionsData
    {
        public List<string> models = new()
        {
            "A4",
            "A5",
            "A6"
        };
        public List<string> sectors = new()
        {
            "Soldadura"
        };
        public List<string> parts = new()
        {
            "Tanque Terminado",
            "Tapa-Funda Tanque",
            "Fondo-Caños Tanque"
        };
    }
}