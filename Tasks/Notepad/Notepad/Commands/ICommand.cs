
namespace Notepad.Commands
{
  /// <summary>
  /// 
  /// </summary>
  public interface ICommand
  {
    string Name();
    void Execute();
  }
}
