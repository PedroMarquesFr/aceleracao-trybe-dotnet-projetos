namespace month_name;
public class MonthNameInCalendar
{
    public static string MonthName(int month)
    {
        Dictionary<int, string> months = new()
        {
            { 1, "Janeiro" },
            { 2, "Fevereiro" },
            { 3, "Março" },
            { 4, "Abril" },
            { 5, "Maio" },
            { 6, "Junho" },
            { 7, "Julho" },
            { 8, "Agosto" },
            { 9, "Setembro" },
            { 10, "Outubro" },
            { 11, "Novembro" },
            { 12, "Dezembro" }
        };
        if (month > 12 || month < 1) return "inválido";
        
        return months[month];
    }
}