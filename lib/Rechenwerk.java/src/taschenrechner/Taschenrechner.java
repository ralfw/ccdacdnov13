package taschenrechner;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Taschenrechner implements Serializable {
	
	private Operator operator = Operator.KEINER;

	private int linkeSeite;

	private int rechteSeite;
	
	public int hierZiffer(Ziffer ziffer) {
		if(operator == Operator.KEINER) {
			zurLinkenSeiteZifferHinzufuegen(ziffer);
			return linkeSeite;
		} else {
			zurRechtenSeiteZifferHinzufuegen(ziffer);
			return rechteSeite;
		}
	}

	private void zurLinkenSeiteZifferHinzufuegen(Ziffer ziffer) {
		linkeSeite = 10*linkeSeite + ziffer.getWert();
	}
	private void zurRechtenSeiteZifferHinzufuegen(Ziffer ziffer) {
		rechteSeite = 10*rechteSeite + ziffer.getWert();
	}
	public int hierOperand(Operator operator) {
		if (this.operator != Operator.KEINER) {
			linkeSeite = this.operator.berechne(linkeSeite, rechteSeite);
			rechteSeite = 0;
		}
		this.operator = operator;					
		return linkeSeite;
	}

	public void schreibe(String file) throws FileNotFoundException, IOException {
		new ObjectOutputStream(new FileOutputStream(file)).writeObject(this);
	}
	public static Taschenrechner lade(String file) throws ClassNotFoundException, IOException {
		try {
			return (Taschenrechner) new ObjectInputStream(new FileInputStream(file)).readObject();
		} catch(FileNotFoundException e) {
			return new Taschenrechner();
		}
	}
	public static void main(String[] args) throws FileNotFoundException, IOException, ClassNotFoundException {
		char parameter = args[0].charAt(0);
		Ziffer ziffer = null;
		Operator operator = null;
		switch (parameter)
		{
		case '1' : ziffer = Ziffer.EINS; break;
		case '2' : ziffer = Ziffer.ZWEI; break; 
		case '3' : ziffer = Ziffer.DREI;  break;
		case '4' : ziffer = Ziffer.VIER;  break;
		case '5' : ziffer = Ziffer.FUENF;  break;
		case '6' : ziffer = Ziffer.SECHS;  break;
		case '7' : ziffer = Ziffer.SIEBEN;  break;
		case '8' : ziffer = Ziffer.ACHT;  break;
		case '9' : ziffer = Ziffer.NEUN;  break;
		case '0' : ziffer = Ziffer.NULL;  break;
		case '+' : operator = Operator.PLUS;  break;
		case '-' : operator = Operator.MINUS; break;
		case '*' : operator = Operator.MAL; break;
		case '/' : operator = Operator.DURCH; break;
		case '=' : operator = Operator.ISTGLEICH; break;
		}
		Taschenrechner taschenrechner = Taschenrechner.lade("taschenrechner");
		int ergebnis;
		if (ziffer != null)
			ergebnis = taschenrechner.hierZiffer(ziffer);
		else 
			ergebnis = taschenrechner.hierOperand(operator);
		System.out.println(ergebnis);
		taschenrechner.schreibe("taschenrechner");
			
	}
}
