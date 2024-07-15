Declare @x xml
Set @x =

'<Employees>
  <Employee>
    <EmployeeID>3</EmployeeID>
    <FirstName>Neil</FirstName>
    <LastName>Goldstein</LastName>
    <LatWork>4.086820000000000e+001</LatWork>
    <LongWork>7.342570000000001e+001</LongWork>
  </Employee>
 </Employees>'

 
Set @x.modify('replace value of /Employees[1]/Employee[1]/LastName[1]/text()[1] with "Goldstone" ')


Select @x;