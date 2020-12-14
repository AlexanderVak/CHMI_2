A = [20, 2, 3, 7; 1, 12, -2, -5; 5, -3, 13, 0;0,0, -1, 15];
b = [5, 4, -3 7];
eps = 0.01;
x=linspace(0,0,length(A))';
n = size(x,1);
normVal=Inf;

nmax=1000;
iter = 0;

while normVal>eps && iter<nmax
    x_old = x;
    for i=1:n
        tmp = 0;
        for j = 1:i-1
            tmp = tmp + A(i,j)* x(j);
        end
        for j = i+1:n
            tmp = tmp + A(i,j) * x_old(j);
        end
        x(i) = (1/A(i,i)) * (b(i) - tmp);
    end
    iter = iter+1;
    normVal = norm(x_old-x);
end
fprintf('Solution of the system is : \n%f\n%f\n%f\n%f\n%f',x);