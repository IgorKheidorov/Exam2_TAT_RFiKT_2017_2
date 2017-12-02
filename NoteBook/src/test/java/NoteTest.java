import org.junit.Test;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

import static org.junit.Assert.assertEquals;

public class NoteTest {
  @Test
  public void hashCodeOneNote() throws Exception {
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Sat Dec 02 19:30:47 EET 2017");
    Note note1 = new Note("dddd", date);
    assertEquals(note1.hashCode(), 502789881);
  }

  @Test
  public void equalsWithSameValueAndDifferentDate() throws ParseException {
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Thu Sep 28 20:29:30 JST 2000");
    Note note1 = new Note("test", date);
    Note note2 = new Note("test", new Date());
    assertEquals(note1.equals(note2), false);
  }

  @Test
  public void equalsWithSameValueAndSameDate() throws ParseException {
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Thu Sep 28 20:29:30 JST 2000");
    Note note1 = new Note("test", date);
    Note note2 = new Note("test", date);
    assertEquals(note1.equals(note2), true);
  }

  @Test
  public void equalsWithDifferentValueAndSameDate() throws ParseException {
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Thu Sep 28 20:29:30 JST 2000");
    Note note1 = new Note("testtest", date);
    Note note2 = new Note("test", date);
    assertEquals(note1.equals(note2), false);
  }

  @Test
  public void equalsWithDiffrentValuesAndDifferentDate() throws ParseException {
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date1 =  df.parse("Thu Sep 28 20:29:30 JST 2000");
    Date date2 =  df.parse("Fri Sep 29 20:29:30 JST 2005");
    Note note1 = new Note("testtest", date1);
    Note note2 = new Note("test", date2);
    assertEquals(note1.equals(note2), false);
  }

  @Test
  public void toStringOneNote() throws Exception {
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Sat Dec 02 19:28:34 EET 2017");
    Note note1 = new Note("dddd", date);
    note1.toString();
    assertEquals(note1.toString().equals(" dddd Sat Dec 02 19:28:34 EET 2017"), true);
  }
}