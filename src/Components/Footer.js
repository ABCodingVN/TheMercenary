import React from 'react'
import { Box } from '@mui/system'

import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';

import { Badge } from '@mui/material';


import { Grid } from '@mui/material';

import FacebookIcon from '@mui/icons-material/Facebook';
import InstagramIcon from '@mui/icons-material/Instagram';
import TwitterIcon from '@mui/icons-material/Twitter';
import AtmIcon from '@mui/icons-material/Atm';

import CommentBankIcon from '@mui/icons-material/CommentBank';
import FoodBankIcon from '@mui/icons-material/FoodBank';
import AttachMoneyIcon from '@mui/icons-material/AttachMoney';
import AddCardIcon from '@mui/icons-material/AddCard';
import {  red,  } from '@mui/material/colors';

export default function Footer() {
  return (
    <div>
       <Box sx={{
                   m:5,
                   alignItems: 'center',
                   justifyContent:"center",
                   overflow: 'hidden',
                   boxShadow: 1,
                   fontWeight: 'bold',
                    }}>
            <Grid xs={12} container direction="row">
              <Grid xs={3}>
                <Box sx={{display:'flex', justifyContent:'flex-end'}}>
                  <Grid>
                  <Grid><Typography variant='h6' sx={{color:red[500]}}>Hỗ trợ khách hàng</Typography></Grid>
                    <Grid><Typography>Hotline :1900-6035</Typography></Grid>
                    <Grid><Typography>(1000 đ/phút, 8h-21h kể cả T7, CN)</Typography></Grid>
                    <Grid><Typography>Phương thức vận chuyển</Typography></Grid>
                    <Grid><Typography>Chính sách đối trả</Typography></Grid>
                    <Grid><Typography>Hỗ trợ khách hàng: hotro@tiki.vn</Typography></Grid>
                    <Grid><Typography>Báo lỗi bảo mật: security@tiki.vn</Typography></Grid>
                  </Grid>
                </Box>
              </Grid>
              
              <Grid xs={3}>
                <Box sx={{display:'flex', justifyContent:'center', alignItems: 'center',}}>
                  <Grid>
                  <Grid><Typography variant='h6' sx={{color:red[500]}}>Thành viên</Typography></Grid>
                    <Grid><Typography>Thi Lê</Typography></Grid>
                    <Grid><Typography>Huy Trần</Typography></Grid>
                    <Grid><Typography>Bùi Quốc Huy</Typography></Grid>
                    <Grid><Typography>Phan Thảo Hiền</Typography></Grid>
                    <Grid><Typography>Nguyễn Thị Nhân</Typography></Grid>
                    <Grid><Typography>Lê Đức Tuyền</Typography></Grid>
                  </Grid>
                </Box>
              </Grid>

              <Grid xs={3}>
                <Box sx={{display:'flex', justifyContent:'center', alignItems: 'center',}}>
                  <Grid>
                  <Grid><Typography variant='h6' sx={{color:red[500]}}>Thanh toán</Typography></Grid>
                    <Grid>

                      <Grid>
                       <IconButton
                          size='large'
                          edge='end'
                          color='inherit'
                        >
                          <Badge><AtmIcon/></Badge>
                        </IconButton>
                        <IconButton
                          size='large'
                          edge='end'
                          color='inherit'
                        >
                          <Badge><CommentBankIcon/></Badge>
                        </IconButton>
                      </Grid>
                      <Grid>
                      <IconButton
                          size='large'
                          edge='end'
                          color='inherit'
                        >
                          <Badge><FoodBankIcon/></Badge>
                        </IconButton>
                        <IconButton
                          size='large'
                          edge='end'
                          color='inherit'
                        >
                          <Badge><AttachMoneyIcon/></Badge>
                        </IconButton>
                      </Grid>
                      <Grid>
                      <IconButton
                          size='large'
                          edge='end'
                          color='inherit'
                        >
                          <Badge><AddCardIcon/></Badge>
                        </IconButton>
                      </Grid>
                    </Grid>
                   
                  </Grid>
                </Box>
              </Grid>

              <Grid xs={3}>
                <Box sx={{display:'flex',justifyContent:'center'}}>
                  <Grid>
                  <Grid><Typography variant='h6' sx={{color:red[500]}}>Kết nối với chúng tôi</Typography></Grid>
                    <Grid>
                    <IconButton
                          size='large'
                          edge='end'
                          color='inherit'
                        >
                          <Badge><FacebookIcon/></Badge>
                        </IconButton>
                        <IconButton
                          size='large'
                          edge='end'
                          color='inherit'
                        >
                          <Badge><InstagramIcon/></Badge>
                        </IconButton>
                        <IconButton
                          size='large'
                          edge='end'
                          color='inherit'
                        >
                          <Badge><TwitterIcon/></Badge>
                        </IconButton>
                    </Grid>
                   
                  </Grid>
                </Box>
              </Grid>

            </Grid>
          </Box>
    </div>
  )
}

