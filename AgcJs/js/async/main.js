//import { firstName, lastName, year } from './profile';
import * as myModule from './profile.js';

function setName(element) {
    element.textContent = firstName + ' ' + lastName;
}
function getName() {
    let strName = myModule.firstName + ' ' + myModule.lastName;
    return strName;
}
import { area, circumference } from './circle';

console.log('圆面积：' + area(4));
console.log('圆周长：' + circumference(14));