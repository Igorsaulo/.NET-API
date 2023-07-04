import { Box, Grid, List, ListItem, ListItemButton, ListItemText, Paper, Typography } from "@mui/material";


const CompraPage = () => {
  return (
    <Grid justifyContent={"center"} container>
    <Grid item xs={10}>
      <Paper 
      elevation={3} 
      sx={{
        width:"100%",
        padding:"20px",
        alignItems:"center",
        display:"flex",
        flexDirection:"column",
        minHeight:"40vh"
      }}
        >
        <Box sx={{width:"100%"}}>
          <Typography color={"black"} variant="h5">Finalizar compras</Typography>
        </Box>
        <Box width={"100%"} bgcolor={"#E0E0E0"} height={"1px"}></Box>
        <Grid item container>
          <Typography variant="h6">1 Dados de entrega</Typography>
          <Grid item xs={12}>
            <Paper sx={{padding:"20px",marginTop:"20px"}} elevation={1}>
              <List>
                <ListItem disablePadding>
                  <ListItemText>
                    <Typography fontWeight={"bold"}>Nome completo</Typography>
                  </ListItemText>
                </ListItem>
                <ListItem disablePadding>
                  <ListItemText>
                    <Typography sx={{display:"inline-block",paddingRight:"10px"}}>Endereço</Typography>
                    <input style={{width:"30rem"}} type="text" />
                    <Typography sx={{display:"inline-block"}} >CEP</Typography>
                  </ListItemText>
                </ListItem>
                <ListItem disablePadding>
                  <ListItemText>
                   
                  </ListItemText>
                </ListItem>
                <ListItem disablePadding>
                  <ListItemText>
                    <Typography>Cidade</Typography>
                  </ListItemText>
                </ListItem>
                <ListItem disablePadding>
                  <ListItemText>
                    <Typography>Estado</Typography>
                  </ListItemText>
                </ListItem>
                <ListItem disablePadding>
                  <ListItemText>
                    <Typography>Telefone</Typography>
                  </ListItemText>
                </ListItem>
              </List>
            </Paper>
            </Grid>
        </Grid>
      </Paper>
      </Grid>
  </Grid>
  );
};

export default CompraPage;