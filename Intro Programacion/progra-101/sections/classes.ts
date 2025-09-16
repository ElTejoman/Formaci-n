
export class Car {


  static className = ' Car '

  public readonly brand: string;
  doors: number;
  fuelTank: number;
  isRunning: boolean;
  type: string;

  private readonly createdAt: number;

  constructor(marca: string, tipo: string) {
    this.brand = marca;
    this.doors = 0;
    this.fuelTank = 0;
    this.isRunning = false;
    this.type = tipo;

    this.createdAt = 123456789;
  }

  turnOn() {
    
    if (this.isRunning) {
      console.log('El carro ya estaba encendido, se dañó el motor');
      return;
    }
    
    if (this.fuelTank <= 0) {
      console.log('Carro no tiene gasolina');
      return;
    }
    this.isRunning = true;
    console.log('Carro encendido');
    
  }

  /*
  gas: number
  gas > 100, this.fuelTank = 100
  gas tiene positivo
  si ya esta lleno, no sobrellenar
  si el tanque es 50 y añado 20 el valor del fuelTank sería 70
  si fuelTank es 90 y añado 50, fuelTank deberia de ser 100
  */
  fillTank(gas: number) {
    
    if (gas <= 0) {
      console.log('el gas tiene que ser positivo')
      return;
    }
     
   
    let newFuelTank = this.fuelTank + gas;
    if (newFuelTank >= 100) {
      this.fuelTank = 100;
    } else {
      this.fuelTank = newFuelTank;
    }
    
}

}

let myMazda = new Car('Honda', 'PickUp');


console.log(myMazda);
myMazda.fillTank(60);
myMazda.fillTank(50);

myMazda.turnOn();
console.log(myMazda);
console.log(Car.className)

//console.log(myMazda.createdAt);

