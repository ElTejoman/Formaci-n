export let carro = {
  color: 'blanco',
  traccion: '4x4',
  llantas: 4,
  puertas: 5,
  marca: 'Mitsubishi'
}

if (carro.puertas === 5) {
  console.log('Camioneta');
} else {
  console.log('Turismo');
}