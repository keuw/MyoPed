var net = require('net');

var globalID = 0;
var clients = [];

//Creates a server
net.createServer((socket)=>{

	console.log("Connection from: ", socket.remotePort);
	clients.push(socket)

	socket.setNoDelay(true);
	socket.disconnected = false;

	socket.on('data', (data) => {
		try{
			console.log(data.toString());
		} catch (err){

		}
	});

	socket.on('end', function() {
  	socket.disconnected = true;
 		var clientIndex = clients.indexOf(socket);
		clients.splice(clientIndex, 1);
 	});


}).listen(8080);

console.log("Server running port 8080\n");
