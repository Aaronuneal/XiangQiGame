using System;

namespace XiangQiGame
{
    //class Program
    //{
        public abstract class ChessPieces
  {
      public enum ChessTypes
      {Soldier,Cannon,Chariot,Hourse,Elephant,Advisor,General}
    // member variables
    
    String Name;

    public ChessPieces(string Name)
    {
      this.Name = Name;
    }

 
  public class Soldier : ChessPieces // Declaration is incomplete
  {
    public Soldier(string Name)
      : base(Name)
      {
          Name = "Soldier";
      }
  }
  
  public class Cannon : ChessPieces // Declaration is incomplete
  {
    public Cannon(string Name)
      : base(Name)
      {
          Name = "Cannon";
      }
  }

  public class Chariot : ChessPieces // Declaration is incomplete
  {
    public Chariot(string Name)
      : base(Name)
      {
          Name = "Chariot";
      }
  }

  public class Horse : ChessPieces // Declaration is incomplete
  {
    public Horse(string Name)
      : base(Name)
      {
          Name = "Horse";
      }
  }
  
  public class Elephant : ChessPieces // Declaration is incomplete
  {
    public Elephant(string Name)
      : base(Name)
      {
          Name = "Elephant";
      }
  }

  public class Advisor : ChessPieces // Declaration is incomplete
  {
    public Advisor(string Name)
      : base(Name)
      {
          Name = "Advisor";
      }
  }

  public class General : ChessPieces // Declaration is incomplete
  {
    public General(string Name)
      : base(Name)
      {
          Name = "General";
      }
  }

}
}


            // Start writting some basic classes:
            //    - Board
            //    - ChessPieces
            //       - Solider
            //       - General
            //       - etc...

            // ChessPieces
            //   --> Method return the name of the piece
            //   --> piece = new Soldier()
            //       console.WriteLine("My name is " & piece.name()) --> "My Name is Soldier"

            // Basic game routine
            //   Player 1 and player 2
            //   Each turn, ask the player to choose a piece, and move

            // Print the board ??