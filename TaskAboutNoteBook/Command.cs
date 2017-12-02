using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAboutNoteBook
{
  /// <summary>
  /// Repesentation of command interface.
  /// </summary>
  interface Command
  {
    /// <summary>
    /// Executes command.
    /// </summary>
    void Execute();
  }
}
