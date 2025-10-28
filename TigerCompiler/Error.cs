namespace TigerCompiler
{
   public class Error
    {
       public Error (string errorMessage, int line, int column)
       {
           ErrorMessage = string.Format("({0},{1}): {2}", line, column, errorMessage);
           Line = line;
           Column = column;
       }

       public string ErrorMessage { get; private set; }

       public int Line { get; private set; }

       public int Column { get; private set; }

       public override string ToString()
       {
           return ErrorMessage;
       }
       
    }
}
