To deploy a service: 
```
kubectl apply -f platforms-depl
```

To restart a deployment: 
```
kubectl rollout restart deployment platforms-depl
```


Minikube: 
destroy server:
minikube delete

create server
minikube start

show the list of the addons:
minikube addons list

Activate ingress addon 
minikube addons enable ingress


