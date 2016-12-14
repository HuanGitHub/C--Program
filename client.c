#include <string.h>
#include <sys/types.h>
#include <stdio.h>
#include <sys/socket.h>
#include <netinet/ip.h>
#include <netinet/in.h>
#include <unistd.h>
#include <arpa/inet.h>
int main(int argc,char *argv[])
{
	int sockfd,con;
	char *p="hello";
	struct sockaddr_in addr;
	addr.sin_family=AF_INET;
	addr.sin_port=htons(8080);
	if(argc!=1)
	{
			addr.sin_addr.s_addr=inet_addr(argv[1]);
	}else{
			addr.sin_addr.s_addr=inet_addr("127.0.0.1");
		}
	char buf[100];
	sockfd=socket(AF_INET,SOCK_STREAM,0);	
	if(sockfd==-1)
	{
		printf("creat socket fail");
		return 1;
	}
		printf("%d\n",sockfd);
	con=connect(sockfd,(void*)&addr,sizeof(addr));
		write(sockfd,"test",sizeof(p));
		read(sockfd,buf,sizeof(buf));
//		printf("%s\n",buf);
	close(sockfd);
}
