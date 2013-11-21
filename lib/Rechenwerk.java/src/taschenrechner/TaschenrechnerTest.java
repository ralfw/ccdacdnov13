package taschenrechner;

import static org.junit.Assert.*;

import org.junit.Test;

public class TaschenrechnerTest {

	@Test
	public void	EINS() {
		Taschenrechner taschenrechner = new Taschenrechner();
		int ergebnis = taschenrechner.hierZiffer(Ziffer.EINS);
		assertEquals(1, ergebnis);
	}
	@Test
	public void EINS_ZWEI() throws Exception {
		Taschenrechner taschenrechner = new Taschenrechner();
		taschenrechner.hierZiffer(Ziffer.EINS);
		int ergebnis = taschenrechner.hierZiffer(Ziffer.ZWEI);
		assertEquals(12, ergebnis);
	}
	@Test
	public void EINS_PLUS() {
		Taschenrechner taschenrechner = new Taschenrechner();
		taschenrechner.hierZiffer(Ziffer.EINS);
		int ergebnis = taschenrechner.hierOperand(Operator.PLUS);
		assertEquals(1, ergebnis);
	}
	@Test
	public void FUENF_MINUS_ZWEI_ISTGLEICH() {
		Taschenrechner taschenrechner = new Taschenrechner();
		taschenrechner.hierZiffer(Ziffer.FUENF);
		taschenrechner.hierOperand(Operator.MINUS);
		taschenrechner.hierZiffer(Ziffer.ZWEI);
		int ergebnis = taschenrechner.hierOperand(Operator.ISTGLEICH);
		assertEquals(3, ergebnis);
	}
	@Test
	public void EINS_PLUS_DREI() {
		Taschenrechner taschenrechner = new Taschenrechner();
		taschenrechner.hierZiffer(Ziffer.EINS);
		taschenrechner.hierOperand(Operator.PLUS);
		int ergebnis = taschenrechner.hierZiffer(Ziffer.DREI);
		assertEquals(3, ergebnis);
	}
	@Test
	public void EINS_PLUS_DREI_VIER() {
		Taschenrechner taschenrechner = new Taschenrechner();
		taschenrechner.hierZiffer(Ziffer.EINS);
		taschenrechner.hierOperand(Operator.PLUS);
		taschenrechner.hierZiffer(Ziffer.DREI);
		int ergebnis = taschenrechner.hierZiffer(Ziffer.VIER);
		assertEquals(34, ergebnis);
	}
	@Test
	public void EINS_PLUS_DREI_VIER_ISTGLEICH() {
		Taschenrechner taschenrechner = new Taschenrechner();
		taschenrechner.hierZiffer(Ziffer.EINS);
		taschenrechner.hierOperand(Operator.PLUS);
		taschenrechner.hierZiffer(Ziffer.DREI);
		taschenrechner.hierZiffer(Ziffer.VIER);
		int ergebnis = taschenrechner.hierOperand(Operator.ISTGLEICH);
		assertEquals(35, ergebnis);
	}
	@Test
	public void EINS_PLUS_DREI_VIER_PLUS() {
		Taschenrechner taschenrechner = new Taschenrechner();
		taschenrechner.hierZiffer(Ziffer.EINS);
		taschenrechner.hierOperand(Operator.PLUS);
		taschenrechner.hierZiffer(Ziffer.DREI);
		taschenrechner.hierZiffer(Ziffer.VIER);
		int ergebnis = taschenrechner.hierOperand(Operator.PLUS);
		assertEquals(35, ergebnis);
	}
	@Test
	public void EINS_PLUS_DREI_VIER_PLUS_PLUS() {
		Taschenrechner taschenrechner = new Taschenrechner();
		taschenrechner.hierZiffer(Ziffer.EINS);
		taschenrechner.hierOperand(Operator.PLUS);
		taschenrechner.hierZiffer(Ziffer.DREI);
		taschenrechner.hierZiffer(Ziffer.VIER);
		taschenrechner.hierOperand(Operator.PLUS);
		int ergebnis = taschenrechner.hierOperand(Operator.PLUS);
		assertEquals(35, ergebnis);
	}
}
