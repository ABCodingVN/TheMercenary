import React, { useEffect, useState } from 'react';
import productApi from '../../api/product';
import {Box,Grid, Paper} from '@material-ui/core';
import ProductSkeletonList from './components/ProductSkeletonList';
import ProductList from './components/ProductList';
import { Pagination } from '@material-ui/lab';


function ProductMain(props) {
    
    const [productList, setProductList] = useState([]);
    const [pagination, setPagination] = useState({
      limit:3,
        total:10,
        page:1
    })
    const [loading, setLoading] = useState(true);
    const [filters, setFilters] = useState({
        _page:1,
        _limit:3
    })
    useEffect(()=> {
       (async () => {
           try{
               const {data, pagination} = await productApi.getAll(filters)
               setProductList(data)
               console.log({data, pagination})
               setPagination(pagination)
           } catch (error) {
                console.log('Failed', error)
           }
           setLoading(false);
       })()
    },[filters])
    const handlePageOnchange = (e, page) => {
        setFilters((prevFiltes)=> ({
            ...prevFiltes,
            _page:page
        }))
    }
    return (
        <Paper elevation={0}>
            {loading ? <ProductSkeletonList length={3} /> : <ProductList data={productList} /> }
            <Box sx={{display:'flex', justifyContent:'center', p:2}}>
                <Pagination 
                    color='primary'
                    count={3}
                    page={pagination.page}
                    onChange={handlePageOnchange}>
                </Pagination>
            </Box>
        </Paper>
    );
}

export default ProductMain;