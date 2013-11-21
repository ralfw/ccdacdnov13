package taschenrechner;

import java.io.Serializable;

public enum Operator implements Serializable {
	KEINER, PLUS, ISTGLEICH, MINUS, MAL, DURCH ;

	public int berechne(int linkeSeite, int rechteSeite) {
		switch (this) {
		case PLUS: return linkeSeite + rechteSeite;
		case MINUS: return linkeSeite - rechteSeite;
		case MAL: return linkeSeite * rechteSeite;
		case DURCH: return linkeSeite / rechteSeite;
		case ISTGLEICH: return linkeSeite;
		}
		throw new IllegalArgumentException();
	}
}
