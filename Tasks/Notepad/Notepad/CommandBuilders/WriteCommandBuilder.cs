using System;
using Notepad.CommandExceptions;
using Notepad.Commands;

namespace Notepad.CommandBuilders
{
  /// <summary>
  /// Class-builder for Write Command
  /// Realizes pattern Chain of responsibility
  /// </summary>
  public class WriteCommandBuilder : CommandBuilder
  {
    /// <summary>
    /// Set successor in chain
    /// </summary>
    /// <param name="successor">successor</param>
    public WriteCommandBuilder(CommandBuilder successor)
    {
      this.successor = successor;
    }

    /// <summary>
    /// If can build command with such params
    /// returns new WriteCommand
    /// Else calls successor and try build command in successor
    /// Throws if cannot return command
    /// </summary>
    /// <param name="provider">provider</param>
    /// <param name="args">args</param>
    /// <returns> Write Command</returns>
    public override Command Build(NoteBookProvider provider, string args)
    {
      try
      {
        return new WriteCommand(provider, args);
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
