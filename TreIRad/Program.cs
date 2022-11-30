using TreIRad;
GameBoard test = new GameBoard(3);

test.PrintBoard();

public class BoardCell
    //BoardCell skapar brädet och använder sig av klassen checker för att tilldela X / O på positioner.
{
    Checker checker;

    public BoardCell(Checker checker)
    {
        Checker1 = checker;
    }
    public Checker Checker1
    {
        get => this.checker;

        set => this.checker = value;
            }

    public void setChecker(Checker checker)
    {
        this.checker = checker;
    }
    public char getChecker()
    {
        return checker.GetCheckerSign();
    }
}
public class Checker
    //klassen tilldelar ett tecken med hjälp av konstruktern och instansmetoderna
{
    char checkSign;
    Checker() { }
    public Checker(char checkSign) 
    {
        CheckSign = checkSign;
    }
    public char CheckSign
    {
        get => this.checkSign;
        set =>this.checkSign = value;
    }
    public char GetCheckerSign()
    {
        return checkSign;
    }
        
}
public class GameBoard
{
    int boardSize;
    BoardCell[][] board;
    GameBoard() { }
    public GameBoard(int boardSize)
    {
        this.SetBoardSize(boardSize);
        this.SetBoard(boardSize);
    }
    public void SetBoardSize(int boardSize)
    {
        this.boardSize = boardSize;
    }
    public int GetBoardSize()
    {
        return this.boardSize;
    }
    public void SetBoard(int boardSize)
    {
        board = new BoardCell[boardSize][];



        for (int i = 0; i < boardSize; i++)
        {
            BoardCell[] row = new BoardCell[boardSize];
            for (int j = 0; j < row.Length; j++)
            {
                row[j] = new BoardCell(new Checker(' '));
            }
            board[i] = row;
        }
    }
    public BoardCell[][] getBoard()
    {
        return this.board;
    }
    public void PrintBoard()
    {
        Console.WriteLine($"+___+___+___+");
        Console.WriteLine($"| {board[0][0].getChecker} | {board[0][0].getChecker} | {board[0][0].getChecker} |");
        Console.WriteLine($"+___+___+___+");
        Console.WriteLine($"| {board[0][0].getChecker} | {board[0][0].getChecker} | {board[0][0].getChecker} |");
        Console.WriteLine($"+___+___+___+");
        Console.WriteLine($"| {board[0][0].getChecker} | {board[0][0].getChecker} | {board[0][0].getChecker} |");
        Console.WriteLine($"+___+___+___+");

    }

}