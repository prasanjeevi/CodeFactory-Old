// var dt = document.createElement("dt");
// var key = document.createTextNode("Coffee");

// var dd = document.createElement("dd");
// var value = document.createTextNode("Balance Coffee");

// dt.appendChild(key);
// dd.appendChild(value);

// document.getElementById('env-list').appendChild(dt);
// document.getElementById('env-list').appendChild(dd);
let template = document.getElementById('tb-template');


Array.prototype.forEach.call(Object.keys(process.env).sort().filter(k => !k.startsWith('npm')), (envKey) => {
  let clone = document.importNode(template.content, true)
  // let dt = template.content.querySelector('dt');
  // dt.textContent = envKey;
  // let dd = template.content.querySelector('dd');
  // dd.textContent = process.env[envKey];
  let dt = template.content.querySelectorAll('td')[0];
  dt.textContent = envKey;
  let dd = template.content.querySelectorAll('td')[1];
  if(envKey === 'PATH')
  dd.innerHTML = process.env[envKey].replace(/:/g,"<br>");
  else
  dd.textContent = process.env[envKey];
  document.getElementById('env-list').appendChild(clone);
})
Array.prototype.forEach.call(Object.keys(process.env).sort().filter(k => k.startsWith('npm')), (envKey) => {
  let clone = document.importNode(template.content, true)
  // let dt = template.content.querySelector('dt');
  // dt.textContent = envKey;
  // let dd = template.content.querySelector('dd');
  // dd.textContent = process.env[envKey];
  let dt = template.content.querySelectorAll('td')[0];
  dt.textContent = envKey;
  let dd = template.content.querySelectorAll('td')[1];
  dd.textContent = process.env[envKey];
  document.getElementById('env-list').appendChild(clone);
})