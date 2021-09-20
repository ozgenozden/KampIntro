use Northwind
select CategoryID,Count(*) from Products group by CategoryID

select p.ProductName,sum(od.Quantity*od.UnitPrice) total from Products p inner join [Order Details] od
on p.ProductID=od.ProductID 
inner join Orders o
on od.OrderID=o.OrderID
group by p.ProductName