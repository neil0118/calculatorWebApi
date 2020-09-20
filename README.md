# calculatorWebApi
.net core 3.1

## set up webapi
git clone https://github.com/neil0118/calculatorWebApi.git
cd calculatorWebApi
dotnet run 


## user guide

### Get request:

params:

 first-number
 
 second-number
 
 

All result: https://localhost:5001/Calculator/{first-Number}/{second-Number}

Add result: https://localhost:5001/Calculator/{first-Number}/{second-Number}/Add

Sub result: https://localhost:5001/Calculator/{first-Number}/{second-Number}/Sub

Multiple result: https://localhost:5001/Calculator/{first-Number}/{second-Number}/Multiple

Division result: https://localhost:5001/Calculator/{first-Number}/{second-Number}/Division

### Post request:

params:

  form-data:
  
    first: first-number
    
    second: second-number
    
    opt: operator
    

get post result url: https://localhost:5001/Calculator/

