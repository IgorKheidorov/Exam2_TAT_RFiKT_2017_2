import java.io.FileNotFoundException;
import java.text.ParseException;

/**
 * This is interface for command.
 */
public interface Command {
  void execute() throws ParseException, FileNotFoundException;
}