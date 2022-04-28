import React from 'react'
import { Container, Typography } from '@mui/material'
import { Box} from '@mui/system'
import Grid from '@mui/material/Grid'
import Button from '@mui/material/Button'
import { grey} from '@mui/material/colors' 

export default function Login() {
  return (
    <>
      <Container fixed>
        <Box sx={{ display:'block',height:'80vh',bgcolor:'#dbeafe',mt:5, borderRadius:3}}>
           
          <Grid container direction='row'>

            <Grid item xs={8}>
               <Box sx={{ bgcolor:'#f3f4f6',height:'80vh',textAlign:'center'}}>
                  <Box sx={{ ml:2,bgcolor:'#f9fafb',height:'78vh',borderRadius:2 }}>
                 <Grid container direction='row' >
                    
                    <Grid xs={6}>
                      <Button variant='contained' sx={{borderRadius:2,overflow:'hiden',p:3,width:'100%',bgcolor:'#f3f4f6'}}>
                        <Typography sx={{fontWeight:'bold',color:grey[900]}}>Dang nhap</Typography>
                      </Button>
                    </Grid>
                    <Grid xs={6}>
                      <Button variant='contained' sx={{borderRadius:2,overflow:'hiden',p:3,width:'100%',bgcolor:'#f3f4f6'}}>
                        <Typography sx={{fontWeight:'bold',color:grey[900]}}>Dang ky</Typography>
                      </Button>
                    </Grid>
                 </Grid>
                  </Box>
               </Box>
            </Grid>
            <Grid sx={{}} item xs={4}>
                <Box
                    sx={{display:'inline',pl:6,mt:10}}
                    width='283px'
                    component='img'
                    src="https://salt.tikicdn.com/ts/upload/eb/f3/a3/25b2ccba8f33a5157f161b6a50f64a60.png?fbclid=IwAR1qmwuF91hg8DIBAOQuMzjwMGe-n6-vxU_ra_fc7jVfaayRWX8MC7MFOhQ"
                ></Box>
                <Grid sx={{mt:2,textAlign:'center',}}>
                  <Typography sx={{
                                   typography: 'subtitle2',
                                   fontWeight:'bold',
                                   fontSize:19,
                                  }}>
                    Mua sắm tại TiKi
                  </Typography>
                  <Typography sx={{pr:2}}>
                    Siêu ưu đãi mỗi ngày
                  </Typography>
                </Grid>
            </Grid>
          </Grid>
           
        </Box>
      </Container>
    </>
  )
}

