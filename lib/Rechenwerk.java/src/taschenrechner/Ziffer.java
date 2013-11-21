package taschenrechner;

public enum Ziffer {
	NULL(0),
	EINS(1),
	ZWEI(2),
	DREI(3),
	VIER(4),
	FUENF(5),
	SECHS(6),
	SIEBEN(7),
	ACHT(8),
	NEUN(9);

	private int wert;

	private Ziffer(int wert) {
		this.wert = wert;
	}
	
	public int getWert() {
		return wert;
	}
}
