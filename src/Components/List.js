
import React, { useEffect, useState } from 'react'
import { Box } from '@mui/system'
import { Grid, IconButton } from '@mui/material'
import { yellow, red } from '@mui/material/colors'
import { Typography } from '@mui/material'
import StarIcon from '@mui/icons-material/Star';
import StarHalfIcon from '@mui/icons-material/StarHalf';
import { Badge } from '@mui/material'
import ReactPaginate from 'react-paginate'
import axios from 'axios'


export default function List() {
    const [offset, setOffset] = useState(0);
    const [data, setData] = useState([]);
    const [perPage] = useState(3);
    const [pageCount, setPageCount] = useState(0);
    const getData = async () => {
        const res = await axios.get(`https://jsonplaceholder.typicode.com/photos`)
        const data = res.data;
            const slice = data.slice(offset,offset+perPage)
            const postData = slice.map(user => 
                <div key={user.id}>
                <Grid>
                    <Grid>
                            <Box sx={{mt:5,mr:5, ml:5,p:1,display:'flex'}}>
                                <Grid container spacing={{ xs: 2, md: 3 }} columns={{ xs: 4, sm: 8, md: 12 }}  >
                                        <Grid item xs={2.4} container direction='row'  >
                                            <Box className='box-shadow' sx={{display:'flex',flexDirection:'row'}} >
                                                <Grid >
                                                    <Grid sx={{m:2.5}} item xs={12} >
                                                        <Box 
                                                            src="https://salt.tikicdn.com/cache/200x200/ts/product/09/a6/c0/23a66e8591c353075b235583124bdd0d.jpg.webp"
                                                            component="img">
                                                        </Box>
                                                    </Grid>
                                                    <Grid>
                                                        <Typography align='center'>{user.title}</Typography>
                                                    </Grid>
                                                    <Grid  direction='row' container>
                                                        <Grid item xs={{}}>
                                                            <IconButton sx={{color:yellow[500]}}>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarHalfIcon/></Badge>
                                                            </IconButton>
                                                        </Grid>
                                                        <Grid item xs={{}}>
                                                            <Typography sx={{lineHeight:3.5, fontSize:12}}>Da ban 12</Typography>
                                                        </Grid>
                                                    </Grid>
                                                    <Grid direction="row" container sx={{p:1}}>
                                                        <Grid item xs={8}><Typography sx={{color:red[800]}}>290.000 Đ</Typography></Grid>
                                                        <Grid item xs={4}><Box sx={{overflow:'hidden',borderRadius:'4px',width:'3rem', boxShadow:1,fontWeight:'bold',color:red[500]}}>-10%</Box></Grid>
                                                    </Grid>
                                                </Grid>
                                            </Box>
                                        </Grid>
                                        <Grid item xs={2.4} container direction='row' >
                                            <Box className='box-shadow' 
                                            >
                                                <Grid>
                                                    <Grid sx={{m:2.5}} item xs={12}>
                                                        <Box 
                                                           src="https://salt.tikicdn.com/cache/200x200/ts/product/09/a6/c0/23a66e8591c353075b235583124bdd0d.jpg.webp"
                                                            component="img">
                                                        </Box>
                                                    </Grid>
                                                    <Grid>
                                                        <Typography align='center'>{user.title}</Typography>
                                                    </Grid>
                                                    <Grid  direction='row' container>
                                                        <Grid item xs={{}}>
                                                            <IconButton sx={{color:yellow[500]}}>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarHalfIcon/></Badge>
                                                            </IconButton>
                                                        </Grid>
                                                        <Grid item xs={{}}>
                                                            <Typography sx={{lineHeight:3.5, fontSize:12}}>Da ban 12</Typography>
                                                        </Grid>
                                                    </Grid>
                                                    <Grid direction="row" container sx={{p:1}}>
                                                        <Grid item xs={8}><Typography sx={{color:red[800]}}>290.000 Đ</Typography></Grid>
                                                        <Grid item xs={4}><Box sx={{overflow:'hidden',borderRadius:'4px',width:'3rem', boxShadow:1,fontWeight:'bold',color:red[500]}}>-10%</Box></Grid>
                                                    </Grid>
                                                </Grid>
                                            </Box>
                                        </Grid>
                                        <Grid item xs={2.4} container direction='row' >
                                            <Box className='box-shadow' 
                                            >
                                                <Grid>
                                                    <Grid sx={{m:2.5}}item xs={12}>
                                                        <Box 
                                                           src="https://salt.tikicdn.com/cache/200x200/ts/product/09/a6/c0/23a66e8591c353075b235583124bdd0d.jpg.webp"
                                                            component="img">
                                                        </Box>
                                                    </Grid>
                                                    <Grid>
                                                        <Typography align='center'>{user.title}</Typography>
                                                    </Grid>
                                                    <Grid  direction='row' container>
                                                        <Grid item xs={{}}>
                                                            <IconButton sx={{color:yellow[500]}}>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarHalfIcon/></Badge>
                                                            </IconButton>
                                                        </Grid>
                                                        <Grid item xs={{}}>
                                                            <Typography sx={{lineHeight:3.5, fontSize:12}}>Da ban 12</Typography>
                                                        </Grid>
                                                    </Grid>
                                                    <Grid direction="row" container sx={{p:1}}>
                                                        <Grid item xs={8}><Typography sx={{color:red[800]}}>290.000 Đ</Typography></Grid>
                                                        <Grid item xs={4}><Box sx={{overflow:'hidden',borderRadius:'4px',width:'3rem', boxShadow:1,fontWeight:'bold',color:red[500]}}>-10%</Box></Grid>
                                                    </Grid>
                                                </Grid>
                                            </Box>
                                        </Grid>
                                        <Grid item xs={2.4} container direction='row' >
                                            <Box className='box-shadow' 
                                            >
                                                <Grid>
                                                    <Grid sx={{m:2.5}} item xs={12}>
                                                        <Box 
                                                        src="https://salt.tikicdn.com/cache/200x200/ts/product/09/a6/c0/23a66e8591c353075b235583124bdd0d.jpg.webp"
                                                            component="img">
                                                        </Box>
                                                    </Grid>
                                                    <Grid>
                                                        <Typography align='center'>{user.title}</Typography>
                                                    </Grid>
                                                    <Grid  direction='row' container>
                                                        <Grid item xs={{}}>
                                                            <IconButton sx={{color:yellow[500]}}>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarHalfIcon/></Badge>
                                                            </IconButton>
                                                        </Grid>
                                                        <Grid item xs={{}}>
                                                            <Typography sx={{lineHeight:3.5, fontSize:12}}>Da ban 12</Typography>
                                                        </Grid>
                                                    </Grid>
                                                    <Grid direction="row" container sx={{p:1}}>
                                                        <Grid item xs={8}><Typography sx={{color:red[800]}}>290.000 Đ</Typography></Grid>
                                                        <Grid item xs={4}><Box sx={{overflow:'hidden',borderRadius:'4px',width:'3rem', boxShadow:1,fontWeight:'bold',color:red[500]}}>-10%</Box></Grid>
                                                    </Grid>
                                                </Grid>
                                            </Box>
                                        </Grid>
                                        <Grid item xs={2.4} container direction='row' >
                                            <Box className='box-shadow' 
                                            >
                                                <Grid>
                                                    <Grid sx={{m:2.5}} item xs={12}>
                                                        <Box 
                                                           src="https://salt.tikicdn.com/cache/200x200/ts/product/09/a6/c0/23a66e8591c353075b235583124bdd0d.jpg.webp"
                                                            component="img">
                                                        </Box>
                                                    </Grid>
                                                    <Grid>
                                                        <Typography align='center'>{user.title}</Typography>
                                                    </Grid>
                                                    <Grid  direction='row' container>
                                                        <Grid item xs={{}}>
                                                            <IconButton sx={{color:yellow[500]}}>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarIcon/></Badge>
                                                                <Badge><StarHalfIcon/></Badge>
                                                            </IconButton>
                                                        </Grid>
                                                        <Grid item xs={{}}>
                                                            <Typography sx={{lineHeight:3.5, fontSize:12}}>Da ban 12</Typography>
                                                        </Grid>
                                                    </Grid>
                                                    <Grid direction="row" container sx={{p:1}}>
                                                        <Grid item xs={8}><Typography sx={{color:red[800]}}>290.000 Đ</Typography></Grid>
                                                        <Grid item xs={4}><Box sx={{overflow:'hidden',borderRadius:'4px',width:'3rem', boxShadow:1,fontWeight:'bold',color:red[500]}}>-10%</Box></Grid>
                                                    </Grid>
                                                </Grid>
                                            </Box>
                                        </Grid>
                                </Grid>     
                            </Box> 
                    </Grid>           
                </Grid> 
            </div>)
             setData(postData)
             setPageCount(Math.ceil(data.length / perPage))
        }
    const handlePageClick = (e) => {
            const selectedPage = e.selected;
            setOffset(selectedPage +1)
        };
    useEffect(()=> {
        getData()
    },[offset])
   
  return (
    <div className='App'>
        {data}
      
        <ReactPaginate
                    previousLabel={"prev"}
                    nextLabel={"next"}
                    breakLabel={"..."}
                    breakClassName={"break-me"}
                    pageCount={pageCount}
                   
                    marginPagesDisplayed={2}
                    pageRangeDisplayed={5}
                    onPageChange={handlePageClick}
                    containerClassName={"pagination"}
                    subContainerClassName={"pages pagination"}
                    activeClassName={"active"}
        />
    </div>
)
}





