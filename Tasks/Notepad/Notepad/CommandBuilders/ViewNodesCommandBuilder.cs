using System;
using Notepad.CommandExceptions;
using Notepad.Commands;

namespace Notepad.CommandBuilders
{
  /// <summary>
  /// Class-builder for View Nodes Command
  /// Realizes pattern Chain of responsibility
  /// </summary>
  public class ViewNodesCommandBuilder : CommandBuilder
  {
    /// <summary>
    /// Set successor in chain
    /// </summary>
    /// <param name="successor">successor</param>
    public ViewNodesCommandBuilder(CommandBuilder successor)
    {
      this.successor = successor;
    }

    /// <summary>
    /// If can build command with such params
    /// returns new  ViewNodesCommand
    /// Else calls successor and try build command in successor
    /// Throws if cannot return command
    /// </summary>
    /// <param name="provider">provider</param>
    /// <param name="args">args</param>
    /// <returns> View Nodes Command</returns>
    public override Command Build(NoteBookProvider provider, string args)
    {
      try
      {
        return new ViewNodesCommand(provider, args);
      }
      catch (CommandTypeException)
      {
        if (successor != null)
        {
          return successor.Build(provider, args);
        }
        throw new ArgumentException();
      }
    }
  }
}
