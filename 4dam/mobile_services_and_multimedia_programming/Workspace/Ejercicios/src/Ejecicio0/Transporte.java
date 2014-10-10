/**
 * 
 */
package Ejecicio0;

/**
 * @author CFGS
 *
 */
public class Transporte {

//	Atributos
//		nº pasajeros
	private int numPasajeros;
//		velocidad
	private float velocidad;
/**
 * @param numPasajeros
 * @param velocidad
 * @param precioPersonaTrayayecto
 */
public Transporte(int numPasajeros, float velocidad,
		float precioPersonaTrayayecto) {
	super();
	this.numPasajeros = numPasajeros;
	this.velocidad = velocidad;
	this.precioPersonaTrayayecto = precioPersonaTrayayecto;
}

/**
* 
*/
public Transporte() {
	super();
	this.numPasajeros = 50;
	this.velocidad = 200;
	this.precioPersonaTrayayecto = 40;
}

//		precio/persona/trayecto
	private float precioPersonaTrayayecto;
	
//	Funciones
//		Getters/Setters
	private int getNumPasajeros() {
		return numPasajeros;
	}
	private void setNumPasajeros(int numPasajeros) {
		this.numPasajeros = numPasajeros;
	}
	private float getVelocidad() {
		return velocidad;
	}
	private void setVelocidad(float velocidad) {
		this.velocidad = velocidad;
	}
	private float getPrecioPersonaTrayayecto() {
		return precioPersonaTrayayecto;
	}
	private void setPrecioPersonaTrayayecto(float precioPersonaTrayayecto) {
		this.precioPersonaTrayayecto = precioPersonaTrayayecto;
	}

//		calculaPrecioTrayecto
	public float calculaPrecioTrayecto() {
		return this.getPrecioPersonaTrayayecto()*this.getNumPasajeros();
	}
	
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Transporte trans = new Transporte(100,50,135);
		System.out.println(trans.calculaPrecioTrayecto());
	}

}
